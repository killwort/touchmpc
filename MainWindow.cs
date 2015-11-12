using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using LyricsCore;
using Ninject;

namespace TouchMPC
{
    public partial class MainWindow : Form
    {
        private NowPlaying nowPlayingPage = new NowPlaying();
        private Database databasePage=new Database();
        private Playlist playlistPage = new Playlist();
        public MainWindow()
        {
            InitializeComponent();
            Program.Kernel.Bind<Display>().ToConstant(nowPlayingPage.LyricsDisplay);
            Program.Kernel.Get<Engine>();
            nowPlayingPage.UpdateStatus();
            
        }

        private void SwitchPage(Control newPage)
        {
            var viewBase = newPage as ViewBase;
            viewUi.SuspendLayout();
            viewUi.Controls.Clear();
            foreach (var view in viewUi.Controls.OfType<ViewBase>())
                view.Deactivated();
            viewUi.Controls.Add(newPage);
            newPage.Dock = DockStyle.Fill;
            viewUi.ResumeLayout();
            viewControls.SuspendLayout();
            viewControls.Controls.Clear();
            if (viewBase!=null)
            {
                viewControls.Controls.Add(viewBase.DetachableViewControlsContainer);
                viewBase.DetachableViewControlsContainer.Dock=DockStyle.Fill;
                viewBase.Activated();
            }
            viewControls.ResumeLayout();
        }
        private void NowPlaying_Click(object sender, EventArgs e)
        {
            SwitchPage(nowPlayingPage);
        }

        private void Database_Click(object sender, EventArgs e)
        {
            SwitchPage(databasePage);
        }

        private void Playlist_Click(object sender, EventArgs e)
        {
            SwitchPage(playlistPage);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            MpcClient.GetSharedClient().Next();
        }

        private void PlayPause_Click(object sender, EventArgs e)
        {
            var status = MpcClient.GetSharedClient().Status();
            string state;
            if (!status.TryGetValue("state", out state))
                state = "stop";
            switch (state)
            {
                case "pause":
                    MpcClient.GetSharedClient().Unpause();
                    break;
                case "play":
                    MpcClient.GetSharedClient().Pause();
                    break;
                default:
                    MpcClient.GetSharedClient().Play();
                    break;
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            MpcClient.GetSharedClient().Previous();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            MpcClient.GetSharedClient().Stop();
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            SwitchPage(nowPlayingPage);
        }
    }
}
