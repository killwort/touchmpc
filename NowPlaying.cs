using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Gdk;
using Gtk;
using LyricsCore;
using Ninject;
using Display = LyricsCore.Display;

namespace TouchMPCGtk
{
    partial class NowPlaying : ViewBase
    {
        public NowPlaying()
        {
            LyricsDisplay = new DisplayProxy(this);
            Build();
            new Thread(() =>
            {
                var myClient = new MpdClient();
                while (true)
                {
                    myClient.Idle();
                    UpdateStatus();
                }
            })
            {IsBackground = true}.Start();
        }

        private class DisplayProxy : Display
        {
            private readonly TouchMPCGtk.NowPlaying _nowPlaying;

            public DisplayProxy(TouchMPCGtk.NowPlaying nowPlaying)
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
            Application.Invoke(delegate
            {
                if (Art.Pixbuf != null)
                {
                    Art.Pixbuf.Dispose();
                    Art.Pixbuf = null;
                }
                if (albumArt != null && albumArt.ImageData != null)
                    try
                    {
                        Art.Pixbuf = new Pixbuf(new MemoryStream(albumArt.ImageData),480/3, 480 / 3);
                    }
                    catch
                    {
                    }
            });
        }

        private void DisplayLyrics(Lyric lyric)
        {
            Application.Invoke(delegate
            {
                Lyrics.Buffer.Text = lyric.Text.Replace("\n", "\r\n");
            });
        }

        public Display LyricsDisplay { get; private set; }

        public void UpdateStatus()
        {
            Application.Invoke(delegate
            {

                var rv = MpdClient.GetSharedClient().CurrentSong() ?? new MpdFileInfo();
                Album.Text = rv.Album;
                Artist.Text = rv.Artist;
                Title.Text = rv.Title;
                ((PlayerChangeForwarder) Program.Kernel.Get<PlayerInteraction>()).PushSongChange(rv.Artist, rv.Album,
                    rv.Title, rv.Path);
                Art.Pixbuf = null;
                Lyrics.Buffer.Text = "";
                OnPlayStateChanged(MpdClient.GetSharedClient().Status());
                OnSongChanged(rv);
            });
        }
        public event EventHandler<Dictionary<string, string>> PlayStateChanged;
        public event EventHandler<MpdFileInfo> SongChanged;
        private void NowPlaying_Resize(object sender, EventArgs e)
        {
            /*pnlStatic.Height = Width / 4;
            albumArt.Width = Width / 4;*/
        }

        protected virtual void OnPlayStateChanged(Dictionary<string, string> e)
        {
            var handler = PlayStateChanged;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnSongChanged(MpdFileInfo e)
        {
            var handler = SongChanged;
            if (handler != null)
                handler(this, e);
        }
    }
}