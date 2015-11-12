using System.Windows.Forms;

namespace TouchMPC
{
    public class ViewBase:UserControl
    {
        public virtual Control DetachableViewControlsContainer { get { return null; } }
        public virtual void Activated() { }
        public virtual void Deactivated() { }
    }
}
