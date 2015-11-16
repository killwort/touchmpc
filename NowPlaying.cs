using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using LyricsCore;
using Ninject;

namespace TouchMPC
{
    public partial class NowPlaying : UserControl
    {
        public NowPlaying()
        {
            LyricsDisplay = new DisplayProxy(this);
            InitializeComponent();
            new Thread(() =>
            {
                var myClient = new MpdClient();
                while (true)
                {
                    myClient.Idle();
                    UpdateStatus();
                }
            }) {IsBackground = true}.Start();
        }
        private class DisplayProxy : Display
        {
            private readonly NowPlaying _nowPlaying;

            public DisplayProxy(NowPlaying nowPlaying)
            {
                _nowPlaying = nowPlaying;
            }

            public override void DoDisplay(Lyric lyric)
            {
                _nowPlaying.DisplayLyrics(lyric);
            }

            public override void DoDisplay(AlbumArt albumArt)
            {
                _nowPlaying.DisplayAlbumArt(albumArt);
            }
        }

        private void DisplayAlbumArt(AlbumArt albumArt)
        {
            var act = new Action(() =>
            {
                if (albumArt != null&&albumArt.ImageData!=null)
                    try
                    {
                        this.albumArt.Image = Image.FromStream(new MemoryStream(albumArt.ImageData));
                    }
                    catch
                    {
                        this.albumArt.Image = null;
                    }
                else
                    this.albumArt.Image = null;
            });
            if (InvokeRequired)
                Invoke(act);
            else
                act();
        }

        private void DisplayLyrics(Lyric lyric)
        {
            var act = new Action(() => lLyrics.Text = lyric.Text.Replace("\n", "\r\n"));
            if (InvokeRequired)
                Invoke(act);
            else
                act();
        }

        public Display LyricsDisplay { get; private set; }

        public void UpdateStatus()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateStatus));
                return;
            }
            var rv = MpdClient.GetSharedClient().CurrentSong()??new MpdFileInfo();
            lblAlbum.Text = rv.Album;
            lblArtist.Text = rv.Artist;
            lblTitle.Text = rv.Title;
            ((PlayerChangeForwarder) Program.Kernel.Get<PlayerInteraction>()).PushSongChange(rv.Artist, rv.Album,
                rv.Title, rv.Path);
            OnStateChanged(MpdClient.GetSharedClient().Status());
        }
        private Point? grabPoint;
        private int grabScroll;

        private void lLyrics_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                grabPoint = e.Location;
                grabScroll = pnlScroll.VerticalScroll.Value;
                ((Control)sender).Capture = true;
            }

        }

        private void lLyrics_MouseUp(object sender, MouseEventArgs e)
        {
            grabPoint = null;
            ((Control)sender).Capture = false;

        }

        private void lLyrics_MouseMove(object sender, MouseEventArgs e)
        {
            if (grabPoint.HasValue)
            {
                var newScroll = grabScroll - (e.Location.Y - grabPoint.Value.Y);
                pnlScroll.VerticalScroll.Value = Math.Max(Math.Min(pnlScroll.VerticalScroll.Maximum, newScroll), pnlScroll.VerticalScroll.Minimum);
            }
            pnlScroll.Focus();
        }

        public event EventHandler<Dictionary<string, string>> StateChanged;

        private void NowPlaying_Resize(object sender, EventArgs e)
        {
            pnlStatic.Height = Width/4;
            albumArt.Width = Width/4;
        }

        protected virtual void OnStateChanged(Dictionary<string, string> e)
        {
            var handler = StateChanged;
            if (handler != null) handler(this, e);
        }
    }
}
