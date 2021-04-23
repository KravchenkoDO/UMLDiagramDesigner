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
    class SelectHandler : AbstractHandler
    {
        public Canvas canvas = Canvas.GetCanvas();

        public override void MouseClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (var element in canvas._listAbstractDiagramElements)
                {
                    if (element.CheckIfTheObjectIsClicked(e.Location))
                    {
                        _currentDiagramElement = element;
                        break;
                    }
                }
            }
        }

        public override AbstractDiagramElement ReturnElement()
        {
            return _currentDiagramElement;
        }

        public override void MouseDown(MouseEventArgs e) { }

        public override void MouseMove(Point point) { }

        public override void MouseUp() { }

        public override void Paint() { }
    }
}
