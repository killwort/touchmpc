using Gtk;

namespace TouchMPCGtk
{
    public class ViewBase : Bin
    {
        public virtual Widget DetachableViewControlsContainer { get { return null; } }
        public virtual void Activated() { }
        public virtual void Deactivated() { }
    }
}