using System.Drawing;
using System.Windows.Forms;

namespace UML_Diagram_Designer.HandlerClasses
{
    public class DeleteHandler : AbstractHandler
    {
        Canvas canvas = Canvas.GetCanvas();

        public override void MouseClick(MouseEventArgs e)
        {
            foreach (var element in canvas.listAbstractDiagramElements)
            {
                if (element.CheckIfTheObjectIsClicked(e.Location))
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        canvas.listAbstractDiagramElements.Remove(element);
                        canvas.graphics.Clear(Color.White);
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
