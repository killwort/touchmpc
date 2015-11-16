using System.Threading.Tasks;
using LyricsCore;

namespace TouchMPC
{
    class PlayerChangeForwarder:PlayerInteraction
    {
        public void PushSongChange(string artist,string album,string title,string fsPath)
        {
            Task.Factory.StartNew(() =>
            {
                OnSongChanged(new SongEventArgs(new Song
                {
                    Artist = artist,
                    Album = album,
                    Title = title,
                    FilesystemPath = fsPath
                }));
            });
        }
    }
}