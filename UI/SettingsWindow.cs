namespace TouchMPCGtk
{
    public partial class SettingsWindow
    {
        private Gtk.VBox vbox1;

        private Gtk.Label DescriptionLabel;

        private Gtk.HBox hbox1;

        private Gtk.Label HostLabel;

        private Gtk.Entry Host;

        private Gtk.Label PortLabel;

        private Gtk.SpinButton PortNumber;

        private Gtk.HBox hbox2;

        private Gtk.ScrolledWindow scrolledwindow1;

        private Gtk.Label ErrorText;

        private Gtk.Alignment alignment1;

        private Gtk.Button ConnectButton;

        private Gtk.Alignment alignment2;

        private Gtk.Button CloseButton;

        protected virtual void Build()
        {
            //global::Stetic.Gui.Initialize(this);
            // Widget MainWindow
            Title = Mono.Unix.Catalog.GetString("MPD Connection Settings");
            WindowPosition = (Gtk.WindowPosition)4;
            Resizable = false;
            //this.AllowShrink = true;
            // Container child MainWindow.Gtk.Container+ContainerChild
            vbox1 = new Gtk.VBox();
            vbox1.Name = "vbox1";
            vbox1.Spacing = 12;
            vbox1.BorderWidth = (uint)12;
            // Container child vbox1.Gtk.Box+BoxChild
            DescriptionLabel = new Gtk.Label();
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Xalign = 0F;
            DescriptionLabel.LabelProp = Mono.Unix.Catalog.GetString("Provide MPD connection settings");
            vbox1.Add(DescriptionLabel);
            Gtk.Box.BoxChild w1 = (Gtk.Box.BoxChild)vbox1[DescriptionLabel];
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            hbox1 = new Gtk.HBox();
            hbox1.Name = "hbox1";
            hbox1.Spacing = 12;
            // Container child hbox1.Gtk.Box+BoxChild
            HostLabel = new Gtk.Label();
            HostLabel.Name = "HostLabel";
            HostLabel.LabelProp = Mono.Unix.Catalog.GetString("Host");
            hbox1.Add(HostLabel);
            Gtk.Box.BoxChild w2 = (Gtk.Box.BoxChild)hbox1[HostLabel];
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            Host = new Gtk.Entry();
            Host.CanFocus = true;
            Host.Name = "Host";
            Host.IsEditable = true;
            Host.InvisibleChar = '●';
            hbox1.Add(Host);
            Gtk.Box.BoxChild w3 = (Gtk.Box.BoxChild)hbox1[Host];
            w3.Position = 1;
            // Container child hbox1.Gtk.Box+BoxChild
            PortLabel = new Gtk.Label();
            PortLabel.Name = "PortLabel";
            PortLabel.LabelProp = Mono.Unix.Catalog.GetString("Port");
            hbox1.Add(PortLabel);
            Gtk.Box.BoxChild w4 = (Gtk.Box.BoxChild)hbox1[PortLabel];
            w4.Position = 2;
            w4.Expand = false;
            w4.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            PortNumber = new Gtk.SpinButton(1D, 65535D, 1D);
            PortNumber.CanFocus = true;
            PortNumber.Name = "PortNumber";
            PortNumber.Adjustment.PageIncrement = 10D;
            PortNumber.ClimbRate = 1D;
            PortNumber.Numeric = true;
            PortNumber.Value = 1D;
            hbox1.Add(PortNumber);
            Gtk.Box.BoxChild w5 = (Gtk.Box.BoxChild)hbox1[PortNumber];
            w5.Position = 3;
            w5.Expand = false;
            w5.Fill = false;
            vbox1.Add(hbox1);
            Gtk.Box.BoxChild w6 = (Gtk.Box.BoxChild)vbox1[hbox1];
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            hbox2 = new Gtk.HBox();
            hbox2.Name = "hbox2";
            hbox2.Spacing = 12;
            // Container child hbox2.Gtk.Box+BoxChild
            scrolledwindow1 = new Gtk.ScrolledWindow();
            scrolledwindow1.CanFocus = true;
            scrolledwindow1.Name = "scrolledwindow1";
            scrolledwindow1.VscrollbarPolicy = (Gtk.PolicyType)2;
            scrolledwindow1.HscrollbarPolicy = (Gtk.PolicyType)2;
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            Gtk.Viewport w7 = new Gtk.Viewport();
            w7.ShadowType = (Gtk.ShadowType)0;
            // Container child GtkViewport.Gtk.Container+ContainerChild
            ErrorText = new Gtk.Label();
            ErrorText.Name = "ErrorText";
            ErrorText.Xalign = 0F;
            ErrorText.Yalign = 0F;
            ErrorText.Wrap = true;
            w7.Add(ErrorText);
            scrolledwindow1.Add(w7);
            hbox2.Add(scrolledwindow1);
            Gtk.Box.BoxChild w10 = (Gtk.Box.BoxChild)hbox2[scrolledwindow1];
            w10.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            alignment1 = new Gtk.Alignment(0.5F, 0.5F, 1F, 0F);
            alignment1.Name = "alignment1";
            // Container child alignment1.Gtk.Container+ContainerChild
            ConnectButton = new Gtk.Button();
            ConnectButton.CanFocus = true;
            ConnectButton.Name = "ConnectButton";
            ConnectButton.UseUnderline = true;
            ConnectButton.Label = Mono.Unix.Catalog.GetString("Connect");
            alignment1.Add(ConnectButton);
            hbox2.Add(alignment1);
            Gtk.Box.BoxChild w12 = (Gtk.Box.BoxChild)hbox2[alignment1];
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            alignment2 = new Gtk.Alignment(0.5F, 0.5F, 1F, 0F);
            alignment2.Name = "alignment2";
            // Container child alignment2.Gtk.Container+ContainerChild
            CloseButton = new Gtk.Button();
            CloseButton.CanFocus = true;
            CloseButton.Name = "CloseButton";
            CloseButton.UseUnderline = true;
            CloseButton.Label = Mono.Unix.Catalog.GetString("Close");
            alignment2.Add(CloseButton);
            hbox2.Add(alignment2);
            Gtk.Box.BoxChild w14 = (Gtk.Box.BoxChild)hbox2[alignment2];
            w14.Position = 2;
            w14.Expand = false;
            w14.Fill = false;
            vbox1.Add(hbox2);
            Gtk.Box.BoxChild w15 = (Gtk.Box.BoxChild)vbox1[hbox2];
            w15.Position = 2;
            w15.Expand = false;
            w15.Fill = false;
            Add(vbox1);
            if (Child != null)
            {
                Child.ShowAll();
            }
            DefaultWidth = 400;
            DefaultHeight = 300;
            Show();
        }

    }

}
