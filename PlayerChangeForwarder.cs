using System.Threading.Tasks;
using LyricsCore;

namespace TouchMPC
{
    class PlayerChangeForwarder:PlayerInteraction
    {
        public void PushSongChange(string artist,string album,string title)
        {
            Task.Factory.StartNew(() =>
            {
                OnSongChanged(new SongEventArgs(new Song
                {
                    Artist = artist,
                    Album = album,
                    Title = title
                }));
            });
        }
    }
}