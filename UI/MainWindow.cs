using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atk;

namespace TouchMPCGtk
{
    public partial class MainWindow
    {
        private global::Gtk.HBox hbox4;

        private global::Gtk.VBox vbox3;

        private global::Gtk.Alignment MainUiContainer;

        private global::Gtk.HBox hbox5;

        private global::Gtk.Alignment ButtonsUiContainer;

        private global::Gtk.Button PrevButton;

        private global::Gtk.Button StopButton;

        private global::Gtk.Button PlayButton;

        private global::Gtk.Button NextButton;

        private global::Gtk.VBox vbox2;

        private global::Gtk.Button NowPlayingButton;

        private global::Gtk.Button DatabaseButton;

        private global::Gtk.Button PlaylistButton;

        private global::Gtk.CheckButton RepeatToggle;

        private global::Gtk.CheckButton ShuffleToggle;

        private Gtk.Button LogButton;

        protected virtual void Build()
        {
            // Widget GtkSharpTest.Window
            this.Title = global::Mono.Unix.Catalog.GetString("Touch MPC GTK");
            this.WindowPosition = ((global::Gtk.WindowPosition)(4));
            // Container child GtkSharpTest.Window.Gtk.Container+ContainerChild
            this.hbox4 = new global::Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            this.hbox4.BorderWidth = ((uint)(12));
            // Container child hbox4.Gtk.Box+BoxChild
            this.vbox3 = new global::Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.MainUiContainer = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.MainUiContainer.Name = "MainUiContainer";
            this.vbox3.Add(this.MainUiContainer);
            global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.MainUiContainer]));
            w1.Position = 0;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox5 = new global::Gtk.HBox();
            this.hbox5.Name = "hbox5";
            this.hbox5.Spacing = 6;
            // Container child hbox5.Gtk.Box+BoxChild
            this.ButtonsUiContainer = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.ButtonsUiContainer.Name = "ButtonsUiContainer";
            this.hbox5.Add(this.ButtonsUiContainer);
            global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.ButtonsUiContainer]));
            w2.Position = 0;
            // Container child hbox5.Gtk.Box+BoxChild
            this.PrevButton = new global::Gtk.Button();
            this.PrevButton.CanFocus = true;
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.UseUnderline = true;
            this.PrevButton.Label = global::Mono.Unix.Catalog.GetString("Pre_vious");
            this.hbox5.Add(this.PrevButton);
            global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.PrevButton]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            this.StopButton = new global::Gtk.Button();
            this.StopButton.CanFocus = true;
            this.StopButton.Name = "StopButton";
            this.StopButton.UseUnderline = true;
            this.StopButton.Label = global::Mono.Unix.Catalog.GetString("Stop");
            this.hbox5.Add(this.StopButton);
            global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.StopButton]));
            w5.Position = 2;
            w5.Expand = false;
            w5.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            this.PlayButton = new global::Gtk.Button();
            this.PlayButton.CanFocus = true;
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.UseUnderline = true;
            this.PlayButton.Label = global::Mono.Unix.Catalog.GetString("Play");
            this.hbox5.Add(this.PlayButton);
            global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.PlayButton]));
            w6.Position = 3;
            w6.Expand = false;
            w6.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            this.NextButton = new global::Gtk.Button();
            this.NextButton.CanFocus = true;
            this.NextButton.Name = "NextButton";
            this.NextButton.UseUnderline = true;
            this.NextButton.Label = global::Mono.Unix.Catalog.GetString("Next");
            this.hbox5.Add(this.NextButton);
            global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.NextButton]));
            w7.Position = 4;
            w7.Expand = false;
            w7.Fill = false;
            this.vbox3.Add(this.hbox5);
            global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox5]));
            w8.Position = 1;
            w8.Expand = false;
            w8.Fill = false;
            this.hbox4.Add(this.vbox3);
            global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox3]));
            w9.Position = 0;
            // Container child hbox4.Gtk.Box+BoxChild
            this.vbox2 = new global::Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.NowPlayingButton = new global::Gtk.Button();
            this.NowPlayingButton.CanFocus = true;
            this.NowPlayingButton.Name = "NowPlayingButton";
            this.NowPlayingButton.UseUnderline = true;
            this.NowPlayingButton.Label = global::Mono.Unix.Catalog.GetString("Now Playing");
            this.vbox2.Add(this.NowPlayingButton);
            global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.NowPlayingButton]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.DatabaseButton = new global::Gtk.Button();
            this.DatabaseButton.CanFocus = true;
            this.DatabaseButton.Name = "DatabaseButton";
            this.DatabaseButton.UseUnderline = true;
            this.DatabaseButton.Label = global::Mono.Unix.Catalog.GetString("Database");
            this.vbox2.Add(this.DatabaseButton);
            global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.DatabaseButton]));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.PlaylistButton = new global::Gtk.Button();
            this.PlaylistButton.CanFocus = true;
            this.PlaylistButton.Name = "PlaylistButton";
            this.PlaylistButton.UseUnderline = true;
            this.PlaylistButton.Label = global::Mono.Unix.Catalog.GetString("Playlist");
            this.vbox2.Add(this.PlaylistButton);
            global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.PlaylistButton]));
            w12.Position = 2;
            w12.Expand = false;
            w12.Fill = false;
            // Container child
            LogButton = new global::Gtk.Button();
            this.LogButton.CanFocus = true;
            this.LogButton.Name = "LogButton";
            this.LogButton.UseUnderline = true;
            this.LogButton.Label = global::Mono.Unix.Catalog.GetString("Log");
            this.vbox2.Add(LogButton);
            var child = ((global::Gtk.Box.BoxChild)(this.vbox2[this.LogButton]));
            child.Position = 3;
            child.Expand = false;
            child.Fill = false;

            // Container child vbox2.Gtk.Box+BoxChild
            this.RepeatToggle = new global::Gtk.CheckButton();
            this.RepeatToggle.CanFocus = true;
            this.RepeatToggle.Name = "RepeatToggle";
            this.RepeatToggle.Label = global::Mono.Unix.Catalog.GetString("Repeat");
            this.RepeatToggle.DrawIndicator = true;
            this.RepeatToggle.UseUnderline = true;
            this.vbox2.Add(this.RepeatToggle);
            global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.RepeatToggle]));
            w13.PackType = ((global::Gtk.PackType)(1));
            w13.Position = 4;
            w13.Expand = false;
            w13.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.ShuffleToggle = new global::Gtk.CheckButton();
            this.ShuffleToggle.CanFocus = true;
            this.ShuffleToggle.Name = "ShuffleToggle";
            this.ShuffleToggle.Label = global::Mono.Unix.Catalog.GetString("Shuffle");
            this.ShuffleToggle.DrawIndicator = true;
            this.ShuffleToggle.UseUnderline = true;
            this.vbox2.Add(this.ShuffleToggle);
            global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.ShuffleToggle]));
            w14.PackType = ((global::Gtk.PackType)(1));
            w14.Position = 5;
            w14.Expand = false;
            w14.Fill = false;
            this.hbox4.Add(this.vbox2);
            global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox2]));
            w15.Position = 1;
            w15.Expand = false;
            w15.Fill = false;
            this.Add(this.hbox4);
            if ((this.Child != null))
            {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 727;
            this.DefaultHeight = 497;
            this.Show();
        }
    }
}
