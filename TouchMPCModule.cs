using MusicData;
using MusicData.Impl;
using Ninject.Modules;

namespace TouchMPCGtk
{
    class TouchMPCModule:NinjectModule
    {
        public override void Load()
        {
            Bind<PlayerInteraction>().To<PlayerChangeForwarder>().InSingletonScope();
            Bind<MetadataTransformer>().To<NullMetadataTransformer>();
            Bind<MusicData.Database>().To<FilesystemDatabase>();

            Bind<Fetcher<Lyric>>().To<LyricWikiLyricFetcher>();
            Bind<Fetcher<Lyric>>().To<DarkLyricsLyricFetcher>();
            Bind<Fetcher<Lyric>>().To<Lyrics123LyricFetcher>();

            Bind<Fetcher<AlbumArt>>().To<FanartTvArtFetcher>();
            Bind<Fetcher<AlbumArt>>().To<DiscogsAlbumArtFetcher>();
            Bind<Fetcher<AlbumArt>>().To<MpdFilesystemArtFetcher>();
        }
    }
}