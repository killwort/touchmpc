using LyricsCore;
using LyricsCore.Impl;
using Ninject.Modules;

namespace TouchMPCGtk
{
    class TouchMPCModule:NinjectModule
    {
        public override void Load()
        {
            Bind<PlayerInteraction>().To<PlayerChangeForwarder>().InSingletonScope();
            Bind<MetadataTransformer>().To<NullMetadataTransformer>();
            Bind<LyricsCore.Database>().To<FilesystemDatabase>();

            Bind<Fetcher<Lyric>>().To<LyricWikiLyricFetcher>();
            Bind<Fetcher<Lyric>>().To<DarkLyricsLyricFetcher>();
            Bind<Fetcher<Lyric>>().To<Lyrics123LyricFetcher>();

            Bind<Fetcher<AlbumArt>>().To<FanartTvArtFetcher>();
            Bind<Fetcher<AlbumArt>>().To<MpdFilesystemArtFetcher>();
        }
    }
}