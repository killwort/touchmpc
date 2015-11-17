
namespace TouchMPCGtk
{
    public partial class Database
    {
        private global::Gtk.VBox vbox5;

        private global::Gtk.Label CurrentPath;

        private global::Gtk.ScrolledWindow GtkScrolledWindow;

        private global::Gtk.IconView Contents;

        protected virtual void Build()
        {
            this.Name = "GtkSharpTest.Database";
            // Container child GtkSharpTest.Database.Gtk.Container+ContainerChild
            this.vbox5 = new global::Gtk.VBox();
            this.vbox5.Name = "vbox5";
            this.vbox5.Spacing = 6;
            // Container child vbox5.Gtk.Box+BoxChild
            this.CurrentPath = new global::Gtk.Label();
            this.CurrentPath.Name = "CurrentPath";
            this.CurrentPath.Xalign = 0F;
            this.CurrentPath.LabelProp = global::Mono.Unix.Catalog.GetString("label11");
            this.vbox5.Add(this.CurrentPath);
            global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild) (this.vbox5[this.CurrentPath]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox5.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType) (1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.Contents = new global::Gtk.IconView();
            this.Contents.CanFocus = true;
            this.Contents.Name = "Contents";
            this.GtkScrolledWindow.Add(this.Contents);
            this.vbox5.Add(this.GtkScrolledWindow);
            global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild) (this.vbox5[this.GtkScrolledWindow]));
            w3.Position = 1;
            this.Add(this.vbox5);
            /*if ((this.Child != null))
            {
                this.Child.ShowAll();
            }*/
            this.Hide();
        }
    }
}