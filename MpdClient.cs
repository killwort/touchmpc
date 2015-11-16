using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace TouchMPCGtk
{
    public class MpdClient
    {
        private static MpdClient _sharedClientInstance;
        public static MpdClient GetSharedClient()
        {
            return _sharedClientInstance ?? (_sharedClientInstance = new MpdClient());
        }

        //private IPEndPoint ipEndPoint;
        private TcpClient tcpClient;
        private object connection=new object();
        private object execution = new object();
        private static Encoding protocolEncoding = new UTF8Encoding(false);
        /*public MpdClient(IPEndPoint ipEndPoint)
        {
            this.ipEndPoint = ipEndPoint;
        }

        public MpdClient(MpdClient @base)
        {
            ipEndPoint = @base.ipEndPoint;
        }*/

        private void Send(string command)
        {
            using (var writer = new StreamWriter(GetTcpClient().GetStream().AsUnclosable(),protocolEncoding))
                writer.WriteLine(command);
        }

        private Tuple<List<string>,string> Receive()
        {
            string line;
            List<string> rv = new List<string>();
            using (var reader = new StreamReader(GetTcpClient().GetStream().AsUnclosable(), protocolEncoding))
                while ((line=reader.ReadLine())!=null && !line.StartsWith("OK") && !line.StartsWith("ACK"))
                    rv.Add(line);
            return Tuple.Create(rv, line);
        }

        public Tuple<List<string>, string> Execute(string command)
        {
            lock (execution)
            {
                while (true)
                {
                    try
                    {
                        Send(command);
                        return Receive();
                    }
                    catch (IOException)
                    {
                        ConnectionFailure(true);
                    }
                }
            }
        }

        private TcpClient GetTcpClient()
        {
            lock (connection)
            {
                if (tcpClient != null && tcpClient.Connected)
                    return tcpClient;
                if (tcpClient != null)
                    tcpClient.Close();
                var client = new TcpClient(Settings.Default.MpdHostname,Settings.Default.MpdPort)
                {
                    ReceiveTimeout = 5000,
                    SendTimeout = 5000
                };
                tcpClient = client;
            }
            Receive();
            return tcpClient;
        }

        public List<MpdFileInfo> ListFiles(string path)
        {
            var items = Execute(string.Format("listfiles \"{0}\"",path));
            if (items.Item2 != "OK")
            {
                ConnectionFailure(false);
                return new List<MpdFileInfo>();
            }
            var list = new List<MpdFileInfo>();
            if (!path.EndsWith("/"))
                path += "/";
            if (path != "/")
                list.Add(new MpdFileInfo
                {
                    Name = "..",
                    Path = Path.GetDirectoryName(Path.GetDirectoryName(path)).Replace('\\', '/'),
                    Type = "_parent"
                });
            ParseListing(path, items, list);
            return list;
        }

        private static void ParseListing(string path, Tuple<List<string>, string> items, List<MpdFileInfo> list)
        {
            MpdFileInfo lastItem = null;

            foreach (var item in items.Item1)
            {
                var parts = item.Split(new[] { ':' }, 2);
                if (parts[0] == "directory" || parts[0] == "file")
                {
                    list.Add(lastItem = new MpdFileInfo { Name = parts[1].Trim(), Type = parts[0], Path = path + parts[1].Trim() });
                }
                else if (parts[0] == "lastModified" && lastItem != null)
                    lastItem.LastModified = parts[1].Trim();
                else if (parts[0] == "Artist" && lastItem != null)
                    lastItem.Artist = parts[1].Trim();
                else if (parts[0] == "AlbumArtist" && lastItem != null)
                    lastItem.AlbumArtist = parts[1].Trim();
                else if (parts[0] == "Title" && lastItem != null)
                    lastItem.Title = parts[1].Trim();
                else if (parts[0] == "Album" && lastItem != null)
                    lastItem.Album = parts[1].Trim();
                else if (parts[0] == "Time" && lastItem != null)
                    lastItem.Time = int.Parse(parts[1].Trim());
                else if (parts[0] == "Id" && lastItem != null)
                    lastItem.Id = parts[1].Trim();

            }
        }

        private void ConnectionFailure(bool networkError)
        {
            if (networkError)
                lock (connection)
                {
                    tcpClient.Close();
                    tcpClient = null;
                }
        }

        public void ClearPlaylist()
        {
            if (Execute("clear").Item2 != "OK")
                ConnectionFailure(false);
        }

        public void AddToPlaylist(string path)
        {
            if (Execute(string.Format("add \"{0}\"", path.TrimStart('/'))).Item2 != "OK")
                ConnectionFailure(false);
        }

        public void Play(int index)
        {
            if (Execute(string.Format("play \"{0}\"",index)).Item2 != "OK")
                ConnectionFailure(false);
        }

        public void RemoveFromPlaylist(int index)
        {
            if (Execute(string.Format("delete \"{0}\"",index)).Item2 != "OK")
                ConnectionFailure(false);
        }

        public List<MpdFileInfo> GetCurrentPlaylist()
        {
            var items = Execute("playlistinfo");
            if (items.Item2 != "OK")
            {
                ConnectionFailure(false);
                return new List<MpdFileInfo>();
            }
            var files = new List<MpdFileInfo>();
            ParseListing("",items,files);
            return files;
        }

        public void Next()
        {
            if (Execute("next").Item2 != "OK")
                ConnectionFailure(false);
        }

        public Dictionary<string, string> Status()
        {
            return Execute("status").Item1.Select(x => x.Split(new[] {':'}, 2)).ToDictionary(x => x[0], x => x[1].TrimStart(' '));
        }

        public void Unpause()
        {
            if (Execute("pause 0").Item2 != "OK")
                ConnectionFailure(false);
        }
        public void Pause()
        {
            if (Execute("pause 1").Item2 != "OK")
                ConnectionFailure(false);
        }
        public void Play()
        {
            if (Execute("play").Item2 != "OK")
                ConnectionFailure(false);
        }
        public void Stop()
        {
            if (Execute("stop").Item2 != "OK")
                ConnectionFailure(false);
        }

        public MpdFileInfo CurrentSong()
        {
            var rv = new List<MpdFileInfo>();
            var items = Execute("currentsong");
            ParseListing("",items,rv);
            if (rv.Any())
                return rv.First();
            return null;
        }

        public void Idle()
        {
            var tcp = GetTcpClient();
            tcp.ReceiveTimeout = 0;
            Send("idle");
            Receive();
        }

        public void Previous()
        {
            if (Execute("previous").Item2 != "OK")
                ConnectionFailure(false);
        }

        public void Random(bool state)
        {
            if (Execute(string.Format("random {0}",state?1:0)).Item2 != "OK")
                ConnectionFailure(false);
        }
        public void Repeat(bool state)
        {
            if (Execute(string.Format("repeat {0}", state ? 1 : 0)).Item2 != "OK")
                ConnectionFailure(false);
        }

        public void PlayId(string id)
        {
            if (Execute(string.Format("playid {0}", id)).Item2 != "OK")
                ConnectionFailure(false);
        }
    }

    public class MpdFileInfo
    {
        public const string TypeFile = "file";
        public const string TypeFolder = "directory";
        public const string TypeParent = "_parent";
        public string Name,Path;
        public string Type;
        public string LastModified;
        public string Artist { get; set; }
        public string AlbumArtist { get; set; }
        public string Title { get; set; }
        public string Album { get; set; }
        public int Time { get; set; }
        public string Id { get; set; }
    }
}
