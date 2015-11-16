namespace TouchMPCGtk
{
    public partial class NowPlaying
    {
        private global::Gtk.VBox vbox4;

        private global::Gtk.HBox hbox6;

        private global::Gtk.Table table1;

        private global::Gtk.Label Album;

        private global::Gtk.Label AlbumLabel;

        private global::Gtk.Label Artist;

        private global::Gtk.Label ArtistLabel;

        private global::Gtk.Label Title;

        private global::Gtk.Label TitleLabel;

        private global::Gtk.Image Art;

        private global::Gtk.ScrolledWindow GtkScrolledWindow;

        private global::Gtk.TextView Lyrics;

        protected virtual void Build()
        {
            this.Name = "GtkSharpTest.NowPlaying";
            // Container child GtkSharpTest.NowPlaying.Gtk.Container+ContainerChild
            this.vbox4 = new global::Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 12;
            // Container child vbox4.Gtk.Box+BoxChild
            this.hbox6 = new global::Gtk.HBox();
            this.hbox6.Name = "hbox6";
            this.hbox6.Spacing = 6;
            // Container child hbox6.Gtk.Box+BoxChild
            this.table1 = new global::Gtk.Table(((uint)(4)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.Album = new global::Gtk.Label();
            this.Album.Name = "Album";
            this.Album.Xalign = 0F;
            this.table1.Add(this.Album);
            global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.Album]));
            w1.TopAttach = ((uint)(2));
            w1.BottomAttach = ((uint)(3));
            w1.LeftAttach = ((uint)(1));
            w1.RightAttach = ((uint)(2));
            w1.XOptions = ((global::Gtk.AttachOptions)(4));
            w1.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.AlbumLabel = new global::Gtk.Label();
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Xalign = 0F;
            this.AlbumLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Album");
            this.table1.Add(this.AlbumLabel);
            global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.AlbumLabel]));
            w2.TopAttach = ((uint)(2));
            w2.BottomAttach = ((uint)(3));
            w2.XOptions = ((global::Gtk.AttachOptions)(4));
            w2.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.Artist = new global::Gtk.Label();
            this.Artist.Name = "Artist";
            this.Artist.Xalign = 0F;
            this.table1.Add(this.Artist);
            global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.Artist]));
            w3.TopAttach = ((uint)(1));
            w3.BottomAttach = ((uint)(2));
            w3.LeftAttach = ((uint)(1));
            w3.RightAttach = ((uint)(2));
            w3.XOptions = ((global::Gtk.AttachOptions)(4));
            w3.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.ArtistLabel = new global::Gtk.Label();
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Xalign = 0F;
            this.ArtistLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Artist");
            this.table1.Add(this.ArtistLabel);
            global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.ArtistLabel]));
            w4.TopAttach = ((uint)(1));
            w4.BottomAttach = ((uint)(2));
            w4.XOptions = ((global::Gtk.AttachOptions)(4));
            w4.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.Title = new global::Gtk.Label();
            this.Title.Name = "Title";
            this.Title.Xalign = 0F;
            this.table1.Add(this.Title);
            global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.Title]));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            w5.XOptions = ((global::Gtk.AttachOptions)(4));
            w5.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.TitleLabel = new global::Gtk.Label();
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Xalign = 0F;
            this.TitleLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Title");
            this.table1.Add(this.TitleLabel);
            global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.TitleLabel]));
            w6.XOptions = ((global::Gtk.AttachOptions)(4));
            w6.YOptions = ((global::Gtk.AttachOptions)(4));
            this.hbox6.Add(this.table1);
            global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.table1]));
            w7.Position = 0;
            w7.Expand = false;
            w7.Fill = false;
            // Container child hbox6.Gtk.Box+BoxChild
            this.Art = new global::Gtk.Image();
            this.Art.Name = "Art";
            this.hbox6.Add(this.Art);
            global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.Art]));
            w8.PackType = ((global::Gtk.PackType)(1));
            w8.Position = 1;
            w8.Expand = false;
            w8.Fill = false;
            this.vbox4.Add(this.hbox6);
            global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox6]));
            w9.Position = 0;
            w9.Expand = false;
            w9.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.Lyrics = new global::Gtk.TextView();
            this.Lyrics.CanFocus = true;
            this.Lyrics.Name = "Lyrics";
            this.GtkScrolledWindow.Add(this.Lyrics);
            this.vbox4.Add(this.GtkScrolledWindow);
            global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.GtkScrolledWindow]));
            w11.Position = 1;
            this.Add(this.vbox4);
            if ((this.Child != null))
            {
                this.Child.ShowAll();
            }
            this.Hide();
        }

    }
}