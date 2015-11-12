using LyricsCore;
using LyricsCore.Impl;
using Ninject.Modules;

namespace TouchMPC
{
    class TouchMPCModule:NinjectModule
    {
        public override void Load()
        {
            Bind<PlayerInteraction>().To<PlayerChangeForwarder>().InSingletonScope();
            Bind<MetadataTransformer>().To<NullMetadataTransformer>();
            Bind<LyricsCore.Database>().To<FilesystemDatabase>();
            Bind<LyricFetcher>().To<LyricWikiLyricFetcher>();
            Bind<LyricFetcher>().To<DarkLyricsLyricFetcher>();
            Bind<LyricFetcher>().To<Lyrics123LyricFetcher>();
            Bind<ArtFetcher>().To<FanartTvArtFetcher>();
        }
    }
}