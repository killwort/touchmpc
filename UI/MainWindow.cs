namespace TouchMPCGtk
{
    public partial class MainWindow
    {
        private Gtk.VBox vbox3;

        private Gtk.Alignment MainUiContainer;

        private Gtk.HBox hbox5;

        private Gtk.Button NowPlayingButton;

        private Gtk.Button DatabaseButton;

        private Gtk.Button PlaylistButton;

        private Gtk.Alignment alignment2;

        private Gtk.VBox vbox1;

        private Gtk.CheckButton ShuffleToggle;

        private Gtk.CheckButton RepeatToggle;

        private Gtk.Alignment ButtonsUiContainer;

        private Gtk.Button PrevButton;

        private Gtk.Button StopButton;

        private Gtk.Button PlayButton;

        private Gtk.Button NextButton;

        protected virtual void Build()
        {
            Stetic.Gui.Initialize(this);
            // Widget GtkSharpTest.Window
            Name = "GtkSharpTest.Window";
            Title = Mono.Unix.Catalog.GetString("Window");
            WindowPosition = (Gtk.WindowPosition)4;
            BorderWidth = (uint)8;
            // Container child GtkSharpTest.Window.Gtk.Container+ContainerChild
            vbox3 = new Gtk.VBox();
            vbox3.Name = "vbox3";
            vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            MainUiContainer = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            MainUiContainer.Name = "MainUiContainer";
            vbox3.Add(MainUiContainer);
            Gtk.Box.BoxChild w1 = (Gtk.Box.BoxChild)vbox3[MainUiContainer];
            w1.Position = 0;
            // Container child vbox3.Gtk.Box+BoxChild
            hbox5 = new Gtk.HBox();
            hbox5.Name = "hbox5";
            // Container child hbox5.Gtk.Box+BoxChild
            NowPlayingButton = new Gtk.Button();
            NowPlayingButton.CanFocus = true;
            NowPlayingButton.Name = "NowPlayingButton";
            NowPlayingButton.UseUnderline = true;
            NowPlayingButton.Label = Mono.Unix.Catalog.GetString("Now Playing");
            hbox5.Add(NowPlayingButton);
            Gtk.Box.BoxChild w2 = (Gtk.Box.BoxChild)hbox5[NowPlayingButton];
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            DatabaseButton = new Gtk.Button();
            DatabaseButton.CanFocus = true;
            DatabaseButton.Name = "DatabaseButton";
            DatabaseButton.UseUnderline = true;
            DatabaseButton.Label = Mono.Unix.Catalog.GetString("Database");
            hbox5.Add(DatabaseButton);
            Gtk.Box.BoxChild w3 = (Gtk.Box.BoxChild)hbox5[DatabaseButton];
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            PlaylistButton = new Gtk.Button();
            PlaylistButton.CanFocus = true;
            PlaylistButton.Name = "PlaylistButton";
            PlaylistButton.UseUnderline = true;
            PlaylistButton.Label = Mono.Unix.Catalog.GetString("Playlist");
            hbox5.Add(PlaylistButton);
            Gtk.Box.BoxChild w4 = (Gtk.Box.BoxChild)hbox5[PlaylistButton];
            w4.Position = 2;
            w4.Expand = false;
            w4.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            alignment2 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            alignment2.Name = "alignment2";
            alignment2.LeftPadding = (uint)6;
            // Container child alignment2.Gtk.Container+ContainerChild
            vbox1 = new Gtk.VBox();
            vbox1.Name = "vbox1";
            vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            ShuffleToggle = new Gtk.CheckButton();
            ShuffleToggle.CanFocus = true;
            ShuffleToggle.Name = "ShuffleToggle";
            ShuffleToggle.Label = Mono.Unix.Catalog.GetString("Shuffle");
            ShuffleToggle.DrawIndicator = true;
            ShuffleToggle.UseUnderline = true;
            vbox1.Add(ShuffleToggle);
            Gtk.Box.BoxChild w5 = (Gtk.Box.BoxChild)vbox1[ShuffleToggle];
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            RepeatToggle = new Gtk.CheckButton();
            RepeatToggle.CanFocus = true;
            RepeatToggle.Name = "RepeatToggle";
            RepeatToggle.Label = Mono.Unix.Catalog.GetString("Repeat");
            RepeatToggle.DrawIndicator = true;
            RepeatToggle.UseUnderline = true;
            vbox1.Add(RepeatToggle);
            Gtk.Box.BoxChild w6 = (Gtk.Box.BoxChild)vbox1[RepeatToggle];
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            alignment2.Add(vbox1);
            hbox5.Add(alignment2);
            Gtk.Box.BoxChild w8 = (Gtk.Box.BoxChild)hbox5[alignment2];
            w8.Position = 3;
            // Container child hbox5.Gtk.Box+BoxChild
            ButtonsUiContainer = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            ButtonsUiContainer.Name = "ButtonsUiContainer";
            hbox5.Add(ButtonsUiContainer);
            Gtk.Box.BoxChild w9 = (Gtk.Box.BoxChild)hbox5[ButtonsUiContainer];
            w9.Position = 4;
            // Container child hbox5.Gtk.Box+BoxChild
            PrevButton = new Gtk.Button();
            PrevButton.CanFocus = true;
            PrevButton.Name = "PrevButton";
            PrevButton.Label = Mono.Unix.Catalog.GetString("Previous");
            hbox5.Add(PrevButton);
            Gtk.Box.BoxChild w10 = (Gtk.Box.BoxChild)hbox5[PrevButton];
            w10.Position = 5;
            w10.Expand = false;
            w10.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            StopButton = new Gtk.Button();
            StopButton.CanFocus = true;
            StopButton.Name = "StopButton";
            StopButton.UseUnderline = true;
            StopButton.Label = Mono.Unix.Catalog.GetString("Stop");
            hbox5.Add(StopButton);
            Gtk.Box.BoxChild w11 = (Gtk.Box.BoxChild)hbox5[StopButton];
            w11.Position = 6;
            w11.Expand = false;
            w11.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            PlayButton = new Gtk.Button();
            PlayButton.CanFocus = true;
            PlayButton.Name = "PlayButton";
            PlayButton.UseUnderline = true;
            PlayButton.Label = Mono.Unix.Catalog.GetString("Play");
            hbox5.Add(PlayButton);
            Gtk.Box.BoxChild w12 = (Gtk.Box.BoxChild)hbox5[PlayButton];
            w12.Position = 7;
            w12.Expand = false;
            w12.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            NextButton = new Gtk.Button();
            NextButton.CanFocus = true;
            NextButton.Name = "NextButton";
            NextButton.UseUnderline = true;
            NextButton.Label = Mono.Unix.Catalog.GetString("Next");
            hbox5.Add(NextButton);
            Gtk.Box.BoxChild w13 = (Gtk.Box.BoxChild)hbox5[NextButton];
            w13.Position = 8;
            w13.Expand = false;
            w13.Fill = false;
            vbox3.Add(hbox5);
            Gtk.Box.BoxChild w14 = (Gtk.Box.BoxChild)vbox3[hbox5];
            w14.Position = 1;
            w14.Expand = false;
            w14.Fill = false;
            Add(vbox3);
            if (Child != null)
            {
                Child.ShowAll();
            }
            DefaultWidth = 727;
            DefaultHeight = 497;
            Show();
        }
    }
}
