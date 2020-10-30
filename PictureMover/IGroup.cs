using System.Windows.Forms;

namespace PictureMover
{
    interface IGroup
    {
        public void Display(Control.ControlCollection controls);
        public Folder GetFolder();
    }
}
