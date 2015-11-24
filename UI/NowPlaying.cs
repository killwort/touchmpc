namespace TouchMPCGtk
{
    public partial class NowPlaying
    {
        private global::Gtk.HPaned hpaned1;

        private global::Gtk.ScrolledWindow GtkScrolledWindow1;

        private global::Gtk.TextView Lyrics;

        private global::Gtk.VBox vbox4;

        private global::Gtk.Table table1;

        private global::Gtk.Label Album;

        private global::Gtk.Label AlbumLabel;

        private global::Gtk.Label Artist;

        private global::Gtk.Label ArtistLabel;

        private global::Gtk.Label Title;

        private global::Gtk.Label TitleLabel;

        private global::Gtk.Image Art;

        protected virtual void Build()
        {
            // Container child GtkSharpTest.NowPlaying.Gtk.Container+ContainerChild
            this.hpaned1 = new global::Gtk.HPaned();
            this.hpaned1.CanFocus = true;
            this.hpaned1.Name = "hpaned1";
            //this.hpaned1.Position = 475;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
            this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
            this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
            this.Lyrics = new global::Gtk.TextView();
            this.Lyrics.CanFocus = true;
            this.Lyrics.Name = "Lyrics";
            this.GtkScrolledWindow1.Add(this.Lyrics);
            this.hpaned1.Add(this.GtkScrolledWindow1);
            global::Gtk.Paned.PanedChild w2 = ((global::Gtk.Paned.PanedChild)(this.hpaned1[this.GtkScrolledWindow1]));
            w2.Resize = false;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.vbox4 = new global::Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 12;
            // Container child vbox4.Gtk.Box+BoxChild
            this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.Album = new global::Gtk.Label();
            this.Album.Name = "Album";
            this.Album.Xalign = 0F;
            this.table1.Add(this.Album);
            global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.Album]));
            w3.TopAttach = ((uint)(2));
            w3.BottomAttach = ((uint)(3));
            w3.LeftAttach = ((uint)(1));
            w3.RightAttach = ((uint)(2));
            w3.XOptions = ((global::Gtk.AttachOptions)(4));
            w3.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.AlbumLabel = new global::Gtk.Label();
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Xalign = 0F;
            this.AlbumLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Album");
            this.table1.Add(this.AlbumLabel);
            global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.AlbumLabel]));
            w4.TopAttach = ((uint)(2));
            w4.BottomAttach = ((uint)(3));
            w4.XOptions = ((global::Gtk.AttachOptions)(4));
            w4.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.Artist = new global::Gtk.Label();
            this.Artist.Name = "Artist";
            this.Artist.Xalign = 0F;
            this.table1.Add(this.Artist);
            global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.Artist]));
            w5.TopAttach = ((uint)(1));
            w5.BottomAttach = ((uint)(2));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            w5.XOptions = ((global::Gtk.AttachOptions)(4));
            w5.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.ArtistLabel = new global::Gtk.Label();
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Xalign = 0F;
            this.ArtistLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Artist");
            this.table1.Add(this.ArtistLabel);
            global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.ArtistLabel]));
            w6.TopAttach = ((uint)(1));
            w6.BottomAttach = ((uint)(2));
            w6.XOptions = ((global::Gtk.AttachOptions)(4));
            w6.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.Title = new global::Gtk.Label();
            this.Title.Name = "Title";
            this.Title.Xalign = 0F;
            this.table1.Add(this.Title);
            global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.Title]));
            w7.LeftAttach = ((uint)(1));
            w7.RightAttach = ((uint)(2));
            w7.XOptions = ((global::Gtk.AttachOptions)(4));
            w7.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.TitleLabel = new global::Gtk.Label();
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Xalign = 0F;
            this.TitleLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Title");
            this.table1.Add(this.TitleLabel);
            global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.TitleLabel]));
            w8.XOptions = ((global::Gtk.AttachOptions)(4));
            w8.YOptions = ((global::Gtk.AttachOptions)(4));
            this.vbox4.Add(this.table1);
            global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.table1]));
            w9.Position = 0;
            w9.Expand = false;
            w9.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.Art = new global::Gtk.Image();
            this.Art.Name = "Art";
            this.vbox4.Add(this.Art);
            global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.Art]));
            w10.Position = 1;
            w10.Expand = true;
            w10.Fill = true;
            this.hpaned1.Add(this.vbox4);
            this.Add(this.hpaned1);
            if ((this.Child != null))
            {
                this.Child.ShowAll();
            }
            this.Hide();
        }
    }

}