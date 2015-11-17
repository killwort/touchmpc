using GLib;
using Gtk;

namespace TouchMPCGtk
{
    public class ViewBase : Alignment
    {

        public virtual Widget DetachableViewControlsContainer { get { return null; } }
        public virtual void Activated() { }
        public virtual void Deactivated() { }


        public ViewBase() : base(.5f, .5f, 1f,1f)
        {
        }
    }
}