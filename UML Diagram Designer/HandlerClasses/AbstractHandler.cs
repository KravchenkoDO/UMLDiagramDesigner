using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_Designer.FactoryClasses;

namespace UML_Diagram_Designer.HandlerClasses
{
    public abstract class AbstractHandler
    {
        public AbstractDiagramElement _currentDiagramElement;
        public AbstractDiagramElementFactory _currentFactory;
        public abstract void MouseDown(MouseEventArgs e);
        public abstract void MouseMove(Point point);
        public abstract void MouseUp();
        public abstract void Paint();
        public abstract void MouseClick(MouseEventArgs e);
        public abstract AbstractDiagramElement ReturnElement();
    }
}
