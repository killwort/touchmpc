using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Gdk;
using Gtk;
using Action = Gtk.Action;

namespace TouchMPCGtk
{
    partial class Database : ViewBase
    {
        private string currentPath = "/";
        private ListStore ContentsList;
        private HBox detachableButtons;
        private Dictionary<string, Pixbuf> icons;
        public Database()
        {
            icons = new Dictionary<string, Pixbuf>
            {
                {"directory", new Pixbuf(new MemoryStream((byte[])Resources.ResourceManager.GetObject("folder")))},
                {"file", new Pixbuf(new MemoryStream((byte[])Resources.ResourceManager.GetObject("song")))},
                {"_parent", new Pixbuf(new MemoryStream((byte[])Resources.ResourceManager.GetObject("up")))},
            };
            Build();

            ContentsList = new ListStore(typeof(string), typeof(Pixbuf), typeof(MpdFileInfo));
            Contents.Model = ContentsList;
            Contents.TextColumn = 0;
            Contents.PixbufColumn = 1;
//            Contents.ItemOrientation=Orientation.Horizontal;
            Contents.ItemActivated += listView_ItemActivate;

            detachableButtons = new HBox(false, 6);
            var b = new Button { Label = "Clear playlist" };
            b.Clicked += ClearPlaylist_Click;
            detachableButtons.Add(b);
            b = new Button { Label = "Add to playlist" };
            b.Clicked += AddToPlaylist_Click;
            detachableButtons.Add(b);
            detachableButtons.ShowAll();

            NavigateTo(currentPath);
        }

        private void NavigateTo(string path)
        {
            Task.Factory.StartNew(() =>
            {
                var filelist = MpdClient.GetSharedClient().ListFiles(path);
                Application.Invoke(delegate {
                    ContentsList.Clear();
                    foreach (var item in filelist
                        .OrderBy(x => x.Type)
                        .ThenBy(x => x.Name))
                    {
                        ContentsList.AppendValues(item.Name, icons[item.Type], item);
                    }
                    
                    CurrentPath.Text = path;
                    currentPath = path;
                });
            });
        }

        private void listView_ItemActivate(object sender, ItemActivatedArgs e)
        {
            TreeIter iter;
            ContentsList.GetIter(out iter, e.Path);
            var info = (MpdFileInfo) ContentsList.GetValue(iter, 2);
            if (info == null)
                return;
            if (info.Type == MpdFileInfo.TypeFolder || info.Type == MpdFileInfo.TypeParent)
                NavigateTo(info.Path);
        }

        public override Widget DetachableViewControlsContainer
        {
            get { return detachableButtons; }
        }


        private void ClearPlaylist_Click(object sender, EventArgs e)
        {
            MpdClient.GetSharedClient().ClearPlaylist();
        }


        private void AddToPlaylist_Click(object sender, EventArgs e)
        {
            
            if (Contents.SelectedItems != null && Contents.SelectedItems.Length> 0)
            {
                foreach (var item in Contents.SelectedItems)
                {
                    TreeIter iter;
                    ContentsList.GetIter(out iter, item);
                    var info = (MpdFileInfo)ContentsList.GetValue(iter,2);
                    if (info == null || info.Type == MpdFileInfo.TypeParent)
                        continue;
                    MpdClient.GetSharedClient().AddToPlaylist(info.Path);
                }
            }
        }
    }
}