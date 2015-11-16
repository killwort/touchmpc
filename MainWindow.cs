using System;
using System.Linq;
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
            nowPlayingPage.StateChanged += NowPlayingPage_StateChanged;
            Program.Kernel.Bind<Display>().ToConstant(nowPlayingPage.LyricsDisplay);
            Program.Kernel.Get<Engine>();
            nowPlayingPage.UpdateStatus();
            
        }

        private bool selfSetting = false;
        private void NowPlayingPage_StateChanged(object sender, System.Collections.Generic.Dictionary<string, string> e)
        {
            selfSetting = true;
            string val;
            if (!e.TryGetValue("repeat", out val)) val = "0";
            cbRepeat.Checked = val != "0";
            if (!e.TryGetValue("shuffle", out val)) val = "0";
            cbShuffle.Checked = val != "0";
            if (!e.TryGetValue("state", out val)) val = "stop";
            btnPlay.Text = val == "play" ? "Pause" : "Play";
            selfSetting = false;
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
            var status = MpdClient.GetSharedClient().Status();
            string state;
            if (!status.TryGetValue("state", out state))
                state = "stop";
            if (state != "play")
                PlayPause_Click(sender, e);
            else
                MpdClient.GetSharedClient().Next();
        }

        private void PlayPause_Click(object sender, EventArgs e)
        {
            var status = MpdClient.GetSharedClient().Status();
            string state;
            if (!status.TryGetValue("state", out state))
                state = "stop";
            switch (state)
            {
                case "pause":
                    MpdClient.GetSharedClient().Unpause();
                    break;
                case "play":
                    MpdClient.GetSharedClient().Pause();
                    break;
                default:
                    MpdClient.GetSharedClient().Play();
                    break;
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            MpdClient.GetSharedClient().Previous();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            MpdClient.GetSharedClient().Stop();
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            SwitchPage(nowPlayingPage);
        }

        private void cbShuffle_CheckedChanged(object sender, EventArgs e)
        {
            if (selfSetting) return;
            MpdClient.GetSharedClient().Shuffle(cbShuffle.Checked);
        }

        private void cbRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (selfSetting) return;
            MpdClient.GetSharedClient().Repeat(cbRepeat.Checked);
        }
    }
}
