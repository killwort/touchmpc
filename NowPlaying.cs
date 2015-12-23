using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Gdk;
using Gtk;
using log4net;
using MusicData;
using Ninject;
using Pango;
using Display = MusicData.Display;

namespace TouchMPCGtk
{
    partial class NowPlaying : ViewBase
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(NowPlaying));

        public NowPlaying()
        {
            LyricsDisplay = new DisplayProxy(this);
            Build();
            Title.ModifyFont(new FontDescription()
            {
                AbsoluteSize = 16 * Pango.Scale.PangoScale
            });
            new Thread(() =>
            {
                var myClient = new MpdClient();
                while (true)
                {
                    try
                    {
                        myClient.Idle(1000);
                    }
                    catch (Exception e)
                    {
                        Logger.Warn("Exception in IDLE loop", e);
                    }
                    UpdateStatus();
                }
            })
            { IsBackground = true }.Start();
            Art.SizeAllocated += Art_SizeAllocated;
            SizeAllocated += NowPlaying_SizeAllocated;
        }

        private void NowPlaying_SizeAllocated(object o, SizeAllocatedArgs args)
        {
            hpaned1.Position = args.Allocation.Width / 2;
        }

        private void Art_SizeAllocated(object o, SizeAllocatedArgs args)
        {
            DisplayAlbumArt(args.Allocation.Width, args.Allocation.Height);
        }

        private byte[] lastArt, lastLastArt;
        private int lastW = 0, lastH = 0;
        private void DisplayAlbumArt(int w, int h)
        {
            if (lastArt == lastLastArt && w == lastW && h == lastH) return;
            lastW = w;
            lastH = h;
            lastLastArt = lastArt;
            if (Art.Pixbuf != null)
            {
                Art.Pixbuf.Dispose();
                Art.Pixbuf = null;
            }

            if (lastArt != null)
                try
                {
                    Art.Pixbuf = new Pixbuf(new MemoryStream(lastArt), w, h);
                }
                catch (Exception e)
                {
                    Logger.Fatal("Error displaying art", e);
                }
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
            Logger.Debug("Displaying album art");
            if (_lastSong != null && albumArt.OriginalMetadata.Title == _lastSong.Title)
                Application.Invoke(delegate
            {
                lastArt = albumArt != null ? albumArt.ImageData : null;
                var size = Art.Allocation;
                DisplayAlbumArt(size.Width, size.Height);
            });
        }

        private void DisplayLyrics(Lyric lyric)
        {
            Logger.Debug("Displaying lyrics");
            if(_lastSong!=null&&lyric.OriginalMetadata.Title==_lastSong.Title)
            Application.Invoke(delegate
            {
                Lyrics.Buffer.Text = lyric.Text.Replace("\n", "\r\n");
            });
        }

        public Display LyricsDisplay { get; private set; }
        private MpdFileInfo _lastSong;
        private string _lastState;

        public void UpdateStatus()
        {
            var rv = MpdClient.GetSharedClient().CurrentSong() ?? new MpdFileInfo();
            var newState = MpdClient.GetSharedClient().Status();
            var oldSong = _lastSong != null && rv.Path == _lastSong.Path;
            string xState;
            newState.TryGetValue("state", out xState);
            var oldState = xState == _lastState;
            if (oldSong && oldState) return;
            _lastSong = rv;
            _lastState = xState;

            Logger.Debug("Status update");
            Application.Invoke(delegate
            {
                Album.Text = rv.Album;
                Artist.Text = rv.Artist;
                Title.Text = rv.Title;
                ((PlayerChangeForwarder)Program.Kernel.Get<PlayerInteraction>()).PushSongChange(rv.Artist, rv.Album,
                    rv.Title, rv.Path);
                Art.Pixbuf = null;
                Lyrics.Buffer.Text = "";
                if (!oldState)
                    OnPlayStateChanged(newState);
                if (!oldSong)
                    OnSongChanged(rv);
            });
        }
        public event EventHandler<Dictionary<string, string>> PlayStateChanged;
        public event EventHandler<MpdFileInfo> SongChanged;

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