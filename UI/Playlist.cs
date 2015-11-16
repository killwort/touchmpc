using System;
using System.Collections.Generic;

namespace TouchMPCGtk
{
    public partial class Playlist
    {
        private global::Gtk.ScrolledWindow GtkScrolledWindow;

        private global::Gtk.TreeView Contents;

        protected virtual void Build()
        {
            // Container child GtkSharpTest.Playlist.Gtk.Container+ContainerChild
            this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.Contents = new global::Gtk.TreeView();
            this.Contents.CanFocus = true;
            this.Contents.Name = "Contents";
            this.GtkScrolledWindow.Add(this.Contents);
            this.Add(this.GtkScrolledWindow);
            if ((this.Child != null))
            {
                this.Child.ShowAll();
            }
            this.Hide();
        }

    }
}