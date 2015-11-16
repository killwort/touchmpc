using System.IO;
using Gtk;

namespace TouchMPCGtk
{
    static class Sugar
    {
        public static UnclosableStream AsUnclosable(this Stream stream)
        {
            return new UnclosableStream(stream);
        }

        public static void Image(this Button button,string resName)
        {
            button.Image = new Image(new Gdk.Pixbuf(new System.IO.MemoryStream((byte[])Resources.ResourceManager.GetObject(resName))));
            button.ImagePosition = PositionType.Top;
            button.TooltipText = button.Label;
            button.Label = null;
        }
    }
}