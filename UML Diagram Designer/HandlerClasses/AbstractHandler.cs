using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_Designer.HandlerClasses
{
    public abstract class AbstractHandler
    {
        public abstract void MouseDown(MouseEventArgs e);
        public abstract void MouseMove(MouseEventArgs e);
        public abstract void MouseUp(MouseEventArgs e);
        public abstract void MouseClick(MouseEventArgs e);
    }
}
