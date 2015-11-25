namespace TouchMPCGtk
{
    public partial class Playlist
    {
        private Gtk.ScrolledWindow GtkScrolledWindow;

        private Gtk.TreeView Contents;

        protected virtual void Build()
        {
            // Container child GtkSharpTest.Playlist.Gtk.Container+ContainerChild
            GtkScrolledWindow = new Gtk.ScrolledWindow();
            GtkScrolledWindow.Name = "GtkScrolledWindow";
            GtkScrolledWindow.ShadowType = (Gtk.ShadowType)1;
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            Contents = new Gtk.TreeView();
            Contents.CanFocus = true;
            Contents.Name = "Contents";
            GtkScrolledWindow.Add(Contents);
            Add(GtkScrolledWindow);
            /*if ((this.Child != null))
            {
                this.Child.ShowAll();
            }*/
            Hide();
        }

    }
}