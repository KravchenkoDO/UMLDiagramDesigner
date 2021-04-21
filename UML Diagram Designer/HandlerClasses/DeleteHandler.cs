using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.HandlerClasses
{
    public class DeleteHandler : AbstractHandler
    {
        public Canvas canvas = Canvas.GetCanvas();
        public override void MouseClick(Point point)
        {
            foreach (var element in canvas._listAbstractDiagramElements)
            {
                if (element.CheckIfTheObjectIsClicked(point))
                {
                    canvas._listAbstractDiagramElements.Remove(element);
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
