using System;
using System.Linq;
using Gdk;
using Gtk;
using log4net;
using log4net.Core;
using MusicData;
using Ninject;
using Pango;
using Display = MusicData.Display;
using Image = Gtk.Image;
using Window = Gtk.Window;
using WindowType = Gtk.WindowType;

namespace TouchMPCGtk
{
    partial class MainWindow : Window
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MainWindow));

        private NowPlaying nowPlayingPage = new NowPlaying();
        private Database databasePage = new Database();
        private Playlist playlistPage = new Playlist();
        private Image playImage = new Image(new Gdk.Pixbuf(new System.IO.MemoryStream((byte[])Resources.ResourceManager.GetObject("play"))));
        private Image pauseImage = new Image(new Gdk.Pixbuf(new System.IO.MemoryStream((byte[])Resources.ResourceManager.GetObject("pause"))));

        public MainWindow() : base(WindowType.Toplevel)
        {
            Build();
            nowPlayingPage.PlayStateChanged += NowPlayingPage_StateChanged;
            nowPlayingPage.SongChanged += NowPlayingPage_SongChanged;
            PrevButton.Image("prev");
            NextButton.Image("next");
            StopButton.Image("stop");
            PlayButton.Label = null;
            NowPlayingButton.Image("nowplaying");
            PlaylistButton.Image("playlist");
            DatabaseButton.Image("database");
            

            NextButton.Clicked += Next_Click;
            StopButton.Clicked +=Stop_Click;
            PlayButton.Clicked += PlayPause_Click;
            PrevButton.Clicked += Prev_Click;
            NowPlayingButton.Clicked += NowPlaying_Click;
            DatabaseButton.Clicked += Database_Click;
            PlaylistButton.Clicked += Playlist_Click;
            ShuffleToggle.Clicked += cbShuffle_CheckedChanged;
            RepeatToggle.Clicked += cbRepeat_CheckedChanged;

            Program.Kernel.Bind<Display>().ToConstant(nowPlayingPage.LyricsDisplay);
            Program.Kernel.Get<Engine>();
            nowPlayingPage.UpdateStatus();
            switch (TouchMPCGtk.Settings.Default.LastPage)
            {
                case "Database":
                    SwitchPage(databasePage);
                    break;
                case "Playlist":
                    SwitchPage(playlistPage);
                    break;
                default:
                    SwitchPage(nowPlayingPage);
                    break;
            }
        }

        private void NowPlayingPage_SongChanged(object sender, MpdFileInfo e)
        {
            Logger.Debug("Song change");
            playlistPage.Follow(e);
            Title = string.Format("{0} from {1} by {2}", e.Title, e.Album, e.Artist);
        }

        private bool selfSetting = false;
        private void NowPlayingPage_StateChanged(object sender, System.Collections.Generic.Dictionary<string, string> e)
        {
            Logger.Debug("State change");
            selfSetting = true;
            string val;
            if (!e.TryGetValue("repeat", out val)) val = "0";
            RepeatToggle.Active = val != "0";
            if (!e.TryGetValue("random", out val)) val = "0";
            ShuffleToggle.Active = val != "0";
            if (!e.TryGetValue("state", out val)) val = "stop";
            PlayButton.TooltipText = val == "play" ? "Pause" : "Play";
            PlayButton.Image=val=="play"?pauseImage:playImage;
            selfSetting = false;
        }
        private void SwitchPage(Widget newPage)
        {
            Logger.DebugFormat("Switching to page {0}", newPage.GetType().Name);
            var viewBase = newPage as ViewBase;

            foreach (var view in MainUiContainer.Children.OfType<ViewBase>())
                view.Deactivated();
            if (MainUiContainer.Child != null)
                MainUiContainer.Remove(MainUiContainer.Child);
            MainUiContainer.Add(newPage);
            newPage.ShowAll();

            if(ButtonsUiContainer.Child!=null)
                ButtonsUiContainer.Remove(ButtonsUiContainer.Child);
            
            if (viewBase != null)
            {
                ButtonsUiContainer.Add(viewBase.DetachableViewControlsContainer);
                viewBase.Activated();
            }

            TouchMPCGtk.Settings.Default.LastPage = newPage.GetType().Name;
            TouchMPCGtk.Settings.Default.Save();
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

        private void cbShuffle_CheckedChanged(object sender, EventArgs e)
        {
            if (selfSetting) return;
            MpdClient.GetSharedClient().Random(ShuffleToggle.Active);
        }

        private void cbRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (selfSetting) return;
            MpdClient.GetSharedClient().Repeat(RepeatToggle.Active);
        }
    }
}