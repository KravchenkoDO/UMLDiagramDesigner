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
    class ChangeColorAndSizeHandler : AbstractHandler
    {
        public Canvas canvas = Canvas.GetCanvas();

        public override void MouseClick(Point point)
        {
            foreach (var element in canvas._listAbstractDiagramElements)
            {
                if (element.CheckIfTheObjectIsClicked(point))
                {
                    canvas._listAbstractDiagramElements.Remove(element);
                    canvas._graphics.Clear(Color.White);
                    element.ObjectPenColor = canvas.PenColor;
                    element.ObjectPenWidth = canvas.PenSize;
                    canvas._listAbstractDiagramElements.Add(element);
                    canvas.RedrawElementsFromElementsList();
                    break;
                }
            }
        }

        public override void MouseDown(Point point) { }

        public override void MouseMove(Point point) { }

        public override void MouseUp() { }

        public override void Paint() { }

        public override AbstractDiagramElement ReturnElement()
        {
            return null;
        }
    }
}
