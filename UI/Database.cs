
namespace TouchMPCGtk
{
    public partial class Database
    {
        private Gtk.VBox vbox5;

        private Gtk.Label CurrentPath;

        private Gtk.ScrolledWindow GtkScrolledWindow;

        private Gtk.IconView Contents;

        protected virtual void Build()
        {
            Name = "GtkSharpTest.Database";
            // Container child GtkSharpTest.Database.Gtk.Container+ContainerChild
            vbox5 = new Gtk.VBox();
            vbox5.Name = "vbox5";
            vbox5.Spacing = 6;
            // Container child vbox5.Gtk.Box+BoxChild
            CurrentPath = new Gtk.Label();
            CurrentPath.Name = "CurrentPath";
            CurrentPath.Xalign = 0F;
            CurrentPath.LabelProp = Mono.Unix.Catalog.GetString("label11");
            vbox5.Add(CurrentPath);
            Gtk.Box.BoxChild w1 = (Gtk.Box.BoxChild) vbox5[CurrentPath];
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox5.Gtk.Box+BoxChild
            GtkScrolledWindow = new Gtk.ScrolledWindow();
            GtkScrolledWindow.Name = "GtkScrolledWindow";
            GtkScrolledWindow.ShadowType = (Gtk.ShadowType) 1;
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            Contents = new Gtk.IconView();
            Contents.CanFocus = true;
            Contents.Name = "Contents";
            GtkScrolledWindow.Add(Contents);
            vbox5.Add(GtkScrolledWindow);
            Gtk.Box.BoxChild w3 = (Gtk.Box.BoxChild) vbox5[GtkScrolledWindow];
            w3.Position = 1;
            Add(vbox5);
            /*if ((this.Child != null))
            {
                this.Child.ShowAll();
            }*/
            Hide();
        }
    }
}