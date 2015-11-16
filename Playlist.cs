using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchMPC
{
    public partial class Playlist : ViewBase
    {
        public Playlist()
        {
            InitializeComponent();
        }
        public override void Activated()
        {
            Task.Factory.StartNew(() =>
            {
                var items = MpdClient.GetSharedClient().GetCurrentPlaylist();
                var act = new Action(() =>
                {
                    listView.SuspendLayout();
                    listView.BeginUpdate();
                    listView.Items.Clear();
                    foreach (var item in items)
                    {
                        var lvi = new ListViewItem(new[]
                        {
                            new ListViewItem.ListViewSubItem(),
                            new ListViewItem.ListViewSubItem {Text=item.Artist},
                            new ListViewItem.ListViewSubItem {Text=item.Album},
                            new ListViewItem.ListViewSubItem {Text=item.Title},
                            new ListViewItem.ListViewSubItem {Text=TimeSpan.FromSeconds(item.Time).ToString("m\\:ss")},
                        }, -1);
                        listView.Items.Add(lvi);
                    }
                    listView_Resize(null,null);
                    listView.EndUpdate();
                    listView.ResumeLayout();
                });
                if (InvokeRequired)
                    Invoke(act);
                else
                    act();
            });
        }

        private void listView_ItemActivate(object sender, EventArgs e)
        {
            if (listView.SelectedIndices != null && listView.SelectedIndices.Count > 0)
            {
                MpdClient.GetSharedClient().Play(listView.SelectedIndices[0]);
            }
        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedIndices!= null && listView.SelectedIndices.Count > 0)
            {
                foreach (int item in listView.SelectedIndices.Cast<int>().OrderByDescending(x=>x))
                    MpdClient.GetSharedClient().RemoveFromPlaylist(item);
                Activated();
            }
        }

        public override Control DetachableViewControlsContainer
        {
            get { return detachableControls; }
        }

        private void listView_Resize(object sender, EventArgs e)
        {
            cStatus.Width = 20;
            cLength.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            var total = listView.Width - 20 - cLength.Width - 20;
            cTitle.Width = total/2;
            cArtist.Width = cAlbum.Width = total/4;
        }

        private void listView_Click(object sender, EventArgs e)
        {
            
            if (listView.SelectedItems != null && listView.SelectedItems.Count == 1)
                listView.SelectedItems[0].Checked = !listView.SelectedItems[0].Checked;
        }
    }
}
