using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchMPCGtk
{
    public partial class SettingsWindow
    {
        private global::Gtk.VBox vbox1;

        private global::Gtk.Label DescriptionLabel;

        private global::Gtk.HBox hbox1;

        private global::Gtk.Label HostLabel;

        private global::Gtk.Entry Host;

        private global::Gtk.Label PortLabel;

        private global::Gtk.SpinButton PortNumber;

        private global::Gtk.HBox hbox2;

        private global::Gtk.ScrolledWindow scrolledwindow1;

        private global::Gtk.Label ErrorText;

        private global::Gtk.Alignment alignment1;

        private global::Gtk.Button ConnectButton;

        private global::Gtk.Alignment alignment2;

        private global::Gtk.Button CloseButton;

        protected virtual void Build()
        {
            //global::Stetic.Gui.Initialize(this);
            // Widget MainWindow
            this.Title = global::Mono.Unix.Catalog.GetString("MPD Connection Settings");
            this.WindowPosition = ((global::Gtk.WindowPosition)(4));
            this.Resizable = false;
            //this.AllowShrink = true;
            // Container child MainWindow.Gtk.Container+ContainerChild
            this.vbox1 = new global::Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 12;
            this.vbox1.BorderWidth = ((uint)(12));
            // Container child vbox1.Gtk.Box+BoxChild
            this.DescriptionLabel = new global::Gtk.Label();
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Xalign = 0F;
            this.DescriptionLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Provide MPD connection settings");
            this.vbox1.Add(this.DescriptionLabel);
            global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.DescriptionLabel]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hbox1 = new global::Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 12;
            // Container child hbox1.Gtk.Box+BoxChild
            this.HostLabel = new global::Gtk.Label();
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Host");
            this.hbox1.Add(this.HostLabel);
            global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.HostLabel]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.Host = new global::Gtk.Entry();
            this.Host.CanFocus = true;
            this.Host.Name = "Host";
            this.Host.IsEditable = true;
            this.Host.InvisibleChar = '●';
            this.hbox1.Add(this.Host);
            global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.Host]));
            w3.Position = 1;
            // Container child hbox1.Gtk.Box+BoxChild
            this.PortLabel = new global::Gtk.Label();
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Port");
            this.hbox1.Add(this.PortLabel);
            global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.PortLabel]));
            w4.Position = 2;
            w4.Expand = false;
            w4.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.PortNumber = new global::Gtk.SpinButton(1D, 65535D, 1D);
            this.PortNumber.CanFocus = true;
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Adjustment.PageIncrement = 10D;
            this.PortNumber.ClimbRate = 1D;
            this.PortNumber.Numeric = true;
            this.PortNumber.Value = 1D;
            this.hbox1.Add(this.PortNumber);
            global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.PortNumber]));
            w5.Position = 3;
            w5.Expand = false;
            w5.Fill = false;
            this.vbox1.Add(this.hbox1);
            global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hbox2 = new global::Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 12;
            // Container child hbox2.Gtk.Box+BoxChild
            this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.VscrollbarPolicy = ((global::Gtk.PolicyType)(2));
            this.scrolledwindow1.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            global::Gtk.Viewport w7 = new global::Gtk.Viewport();
            w7.ShadowType = ((global::Gtk.ShadowType)(0));
            // Container child GtkViewport.Gtk.Container+ContainerChild
            this.ErrorText = new global::Gtk.Label();
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Xalign = 0F;
            this.ErrorText.Yalign = 0F;
            this.ErrorText.Wrap = true;
            w7.Add(this.ErrorText);
            this.scrolledwindow1.Add(w7);
            this.hbox2.Add(this.scrolledwindow1);
            global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.scrolledwindow1]));
            w10.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 0F);
            this.alignment1.Name = "alignment1";
            // Container child alignment1.Gtk.Container+ContainerChild
            this.ConnectButton = new global::Gtk.Button();
            this.ConnectButton.CanFocus = true;
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.UseUnderline = true;
            this.ConnectButton.Label = global::Mono.Unix.Catalog.GetString("Connect");
            this.alignment1.Add(this.ConnectButton);
            this.hbox2.Add(this.alignment1);
            global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.alignment1]));
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.alignment2 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 0F);
            this.alignment2.Name = "alignment2";
            // Container child alignment2.Gtk.Container+ContainerChild
            this.CloseButton = new global::Gtk.Button();
            this.CloseButton.CanFocus = true;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.UseUnderline = true;
            this.CloseButton.Label = global::Mono.Unix.Catalog.GetString("Close");
            this.alignment2.Add(this.CloseButton);
            this.hbox2.Add(this.alignment2);
            global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.alignment2]));
            w14.Position = 2;
            w14.Expand = false;
            w14.Fill = false;
            this.vbox1.Add(this.hbox2);
            global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
            w15.Position = 2;
            w15.Expand = false;
            w15.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null))
            {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 400;
            this.DefaultHeight = 300;
            this.Show();
        }

    }

}
