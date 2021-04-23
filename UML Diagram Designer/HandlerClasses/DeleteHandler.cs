using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_Designer.HandlerClasses
{
    public class DeleteHandler : AbstractHandler
    {
        public Canvas canvas = Canvas.GetCanvas();
        public override void MouseClick(MouseEventArgs e)
        {
            foreach (var element in canvas._listAbstractDiagramElements)
            {
                if (element.CheckIfTheObjectIsClicked(e.Location))
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        canvas._listAbstractDiagramElements.Remove(element);
                        canvas._graphics.Clear(Color.White);
                        canvas.RedrawElementsFromElementsList();
                        break;
                    }
                }
            }
        }

        public override void MouseDown(MouseEventArgs e) { }

        public override void MouseMove(Point point) { }

        public override void MouseUp() { }

        public override void Paint() { }

        public override AbstractDiagramElement ReturnElement()
        {
            return null;
        }
    }
}
