using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchMPC
{
    public partial class Database : ViewBase
    {
        private string currentPath = "/";
        
        public Database()
        {
            InitializeComponent();
            NavigateTo(currentPath);
        }

        private void NavigateTo(string path)
        {
            Task.Factory.StartNew(() =>
            {
                var filelist = MpdClient.GetSharedClient().ListFiles(path);
                var act=new Action(() =>
                {
                    listView.SuspendLayout();
                    listView.BeginUpdate();
                    listView.Items.Clear();
                    listView.Items.AddRange(filelist
                        .OrderBy(x => x.Type)
                        .ThenBy(x => x.Name)
                        .Select(x => new ListViewItem(x.Name, x.Type)
                        {
                            Tag = x
                        }).ToArray());
                    lblCurrentPath.Text = path;
                    currentPath = path;
                    listView.EndUpdate();
                    listView.ResumeLayout();
                });
                if (InvokeRequired)
                    Invoke(act);
                else act();
            });
        }

        private void listView_ItemActivate(object sender, EventArgs e)
        {
            if (listView.SelectedItems != null && listView.SelectedItems.Count > 0)
            {
                var info = listView.SelectedItems[0].Tag as MpdFileInfo;
                if (info == null)
                    return;
                if(info.Type== MpdFileInfo.TypeFolder || info.Type== MpdFileInfo.TypeParent)
                    NavigateTo(info.Path);
            }
        }

        private void ClearPlaylist_Click(object sender, EventArgs e)
        {
            MpdClient.GetSharedClient().ClearPlaylist();
        }

        private void AddToPlaylist_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems != null && listView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView.SelectedItems)
                {
                    var info = item.Tag as MpdFileInfo;
                    if (info == null||info.Type==MpdFileInfo.TypeParent)
                        continue;
                    MpdClient.GetSharedClient().AddToPlaylist(info.Path);
                }
            }
        }

        public override Control DetachableViewControlsContainer
        {
            get { return detachableControls; }
        }

        private void listView_Resize(object sender, EventArgs e)
        {
            var w = listView.Width - 20;
            var minTiles = Math.Max(1, w/200);
            var maxTiles = Math.Max(1, w/100);
            var tileW = 2*w/(maxTiles + minTiles);
            listView.TileSize = new Size(tileW, 52);
        }
    }
}
