using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gtk;

namespace TouchMPCGtk
{
    partial class Playlist : ViewBase
    {
        private ListStore ContentsList;
        private HBox detachableButtons;
        public Playlist()
        {
            Build();

            ContentsList = new ListStore(typeof(bool),typeof(int),typeof(string),typeof(string),typeof(string),typeof(string), typeof(MpdFileInfo));
            ContentsList.SetSortColumnId(1, SortType.Ascending);
            Contents.Model = ContentsList;
            var ren=new CellRendererText();
            Contents.AppendColumn(new TreeViewColumn("", new CellRendererToggle(), "active", 0) {Clickable = true});
            //Contents.AppendColumn(new TreeViewColumn("ID", ren, "text", 1));
            Contents.AppendColumn(new TreeViewColumn("Artist", ren, "text", 2));
            Contents.AppendColumn(new TreeViewColumn("Album", ren, "text", 3));
            Contents.AppendColumn(new TreeViewColumn("Title", ren, "text", 4));
            Contents.AppendColumn(new TreeViewColumn("Length", ren, "text", 5));

            Contents.CursorChanged += Contents_CursorChanged;
            Contents.RowActivated += listView_ItemActivate;

            detachableButtons = new HBox(false, 6);
            var b = new Button { Label = "Remove item" };
            b.Clicked += RemoveItem_Click;
            detachableButtons.Add(b);
            detachableButtons.ShowAll();
        }

        private void Contents_CursorChanged(object sender, EventArgs e)
        {
            if (selfSetting) return;
            TreeIter iter;
            TreePath path;
            TreeViewColumn col;
            Contents.GetCursor(out path, out col);
            if (ContentsList.GetIter(out iter, path))
            {
                ContentsList.SetValue(iter,0,!(bool) ContentsList.GetValue(iter, 0));
            }
        }

        public override void Activated()
        {
            Follow(lastFollow);
            Task.Factory.StartNew(() =>
            {
                var items = MpdClient.GetSharedClient().GetCurrentPlaylist();
                Application.Invoke(delegate 
                {
                    ContentsList.Clear();
                    int index = 0;
                    foreach (var item in items)
                    {
                        ContentsList.AppendValues(false, index++, item.Artist, item.Album, item.Title, TimeSpan.FromSeconds(item.Time).ToString("m\\:ss"), item);
                    }
                });
            });
        }
        
        private void listView_ItemActivate(object sender, RowActivatedArgs e)
        {
            TreeIter iter;
            ContentsList.GetIter(out iter, e.Path);
            var info = (MpdFileInfo)ContentsList.GetValue(iter, 6);
            if (info == null)
                return;
            MpdClient.GetSharedClient().PlayId(info.Id);
        }

        private MpdFileInfo lastFollow;
        internal void Follow(MpdFileInfo e)
        {
            lastFollow = e;
            TreeIter iter;
            var hasItem = ContentsList.GetIterFirst(out iter);
            selfSetting = true;
            while (hasItem)
            {
                var info=(MpdFileInfo)ContentsList.GetValue(iter, 6);
                if (info.Id == e.Id)
                {
                    Contents.SetCursor(ContentsList.GetPath(iter),Contents.Columns[0],false);
                    Contents.ScrollToCell(ContentsList.GetPath(iter), Contents.Columns[0], true, 0.5f,0f);
                    break;
                }
                hasItem = ContentsList.IterNext(ref iter);
            }
            selfSetting = false;

        }

        private bool selfSetting = false;
        private void RemoveItem_Click(object sender, EventArgs e)
        {
            TreeIter iter;
            var hasItem=ContentsList.GetIterFirst(out iter);
            var indices = new List<int>();
            selfSetting = true;
            var index = 0;
            while (hasItem)
            {
                if ((bool) ContentsList.GetValue(iter, 0))
                {
                    hasItem = ContentsList.Remove(ref iter);
                    indices.Add(index);
                }
                else
                    hasItem = ContentsList.IterNext(ref iter);
                index++;
            }
            Sensitive = false;
            Task.Factory.StartNew(() =>
            {
                foreach (var i in indices.OrderByDescending(x => x))
                {
                    MpdClient.GetSharedClient().RemoveFromPlaylist(i);
                }
                Application.Invoke(delegate { Sensitive = true; });
            });
            selfSetting = false;
        }
        
        public override Widget DetachableViewControlsContainer
        {
            get { return detachableButtons; }
        }
        /*
        private void listView_Resize(object sender, EventArgs e)
        {
            cStatus.Width = 20;
            cLength.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            var total = listView.Width - 20 - cLength.Width - 20;
            cTitle.Width = total / 2;
            cArtist.Width = cAlbum.Width = total / 4;
        }

        private void listView_Click(object sender, EventArgs e)
        {

            if (listView.SelectedItems != null && listView.SelectedItems.Count == 1)
                listView.SelectedItems[0].Checked = !listView.SelectedItems[0].Checked;
        }*/
    }
}