using System.Threading.Tasks;
using MusicData;

namespace TouchMPCGtk
{
    class PlayerChangeForwarder:PlayerInteraction
    {
        public void PushSongChange(string artist,string album,string title,string fsPath)
        {
            Task.Factory.StartNew(() =>
            {
                OnSongChanged(new Song
                {
                    Artist = artist,
                    Album = album,
                    Title = title,
                    FilesystemPath = fsPath
                });
            });
        }
    }
}