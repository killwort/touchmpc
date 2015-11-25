namespace TouchMPCGtk
{
    public partial class NowPlaying
    {
        private Gtk.HPaned hpaned1;

        private Gtk.ScrolledWindow GtkScrolledWindow1;

        private Gtk.TextView Lyrics;

        private Gtk.VBox vbox4;

        private Gtk.Label Title;

        private Gtk.HBox hbox1;

        private Gtk.Label Album;

        private Gtk.Label label1;

        private Gtk.Label Artist;

        private Gtk.Image Art;

        protected virtual void Build()
        {
            Stetic.Gui.Initialize(this);
            // Widget GtkSharpTest.NowPlaying
            Stetic.BinContainer.Attach(this);
            Name = "GtkSharpTest.NowPlaying";
            // Container child GtkSharpTest.NowPlaying.Gtk.Container+ContainerChild
            hpaned1 = new Gtk.HPaned();
            hpaned1.CanFocus = true;
            hpaned1.Name = "hpaned1";
            hpaned1.Position = 475;
            // Container child hpaned1.Gtk.Paned+PanedChild
            GtkScrolledWindow1 = new Gtk.ScrolledWindow();
            GtkScrolledWindow1.Name = "GtkScrolledWindow1";
            GtkScrolledWindow1.HscrollbarPolicy = (Gtk.PolicyType)2;
            GtkScrolledWindow1.ShadowType = (Gtk.ShadowType)1;
            // Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
            Lyrics = new Gtk.TextView();
            Lyrics.Name = "Lyrics";
            Lyrics.Editable = false;
            Lyrics.CursorVisible = false;
            Lyrics.WrapMode = (Gtk.WrapMode)2;
            Lyrics.PixelsAboveLines = 1;
            Lyrics.PixelsBelowLines = 1;
            Lyrics.PixelsInsideWrap = 10;
            Lyrics.LeftMargin = 6;
            Lyrics.RightMargin = 6;
            GtkScrolledWindow1.Add(Lyrics);
            hpaned1.Add(GtkScrolledWindow1);
            Gtk.Paned.PanedChild w2 = (Gtk.Paned.PanedChild)hpaned1[GtkScrolledWindow1];
            w2.Resize = false;
            // Container child hpaned1.Gtk.Paned+PanedChild
            vbox4 = new Gtk.VBox();
            vbox4.Name = "vbox4";
            vbox4.Spacing = 12;
            // Container child vbox4.Gtk.Box+BoxChild
            Title = new Gtk.Label();
            Title.Name = "Title";
            Title.Xalign = 0F;
            Title.Wrap = true;
            Title.Justify = (Gtk.Justification)2;
            vbox4.Add(Title);
            Gtk.Box.BoxChild w3 = (Gtk.Box.BoxChild)vbox4[Title];
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            hbox1 = new Gtk.HBox();
            hbox1.Name = "hbox1";
            hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            Album = new Gtk.Label();
            Album.Name = "Album";
            Album.Xalign = 0F;
            Album.Wrap = true;
            hbox1.Add(Album);
            Gtk.Box.BoxChild w4 = (Gtk.Box.BoxChild)hbox1[Album];
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            label1 = new Gtk.Label();
            label1.Name = "label1";
            label1.LabelProp = Mono.Unix.Catalog.GetString("by");
            hbox1.Add(label1);
            Gtk.Box.BoxChild w5 = (Gtk.Box.BoxChild)hbox1[label1];
            w5.Position = 1;
            w5.Expand = false;
            w5.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            Artist = new Gtk.Label();
            Artist.Name = "Artist";
            Artist.Xalign = 0F;
            Artist.Wrap = true;
            hbox1.Add(Artist);
            Gtk.Box.BoxChild w6 = (Gtk.Box.BoxChild)hbox1[Artist];
            w6.Position = 2;
            w6.Expand = false;
            w6.Fill = false;
            vbox4.Add(hbox1);
            Gtk.Box.BoxChild w7 = (Gtk.Box.BoxChild)vbox4[hbox1];
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            Art = new Gtk.Image();
            Art.Name = "Art";
            vbox4.Add(Art);
            Gtk.Box.BoxChild w8 = (Gtk.Box.BoxChild)vbox4[Art];
            w8.Position = 2;
            hpaned1.Add(vbox4);
            Add(hpaned1);
            if (Child != null)
            {
                Child.ShowAll();
            }
            Hide();
        }
    }
}