using osu.Framework.Platform;

namespace osu.Framework.Browser
{
    public class BrowserGameHost : SDLGameHost
    {
        public BrowserGameHost(string gameName)
            : base(gameName)
        {
        }

        protected override IWindow CreateWindow(GraphicsSurfaceType preferredSurface)
        {
            throw new NotImplementedException();
        }

        public override bool OpenFileExternally(string filename)
        {
            throw new NotImplementedException();
        }

        public override bool PresentFileExternally(string filename)
        {
            throw new NotImplementedException();
        }

        public override void OpenUrlExternally(string url)
        {
            throw new NotImplementedException();
        }

        public override Storage GetStorage(string path)
        {
            throw new NotImplementedException();
        }
    }
}

