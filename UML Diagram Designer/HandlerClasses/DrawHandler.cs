using System.Drawing;
using System.Windows.Forms;
using UML_Diagram_Designer.FactoryClasses;

namespace UML_Diagram_Designer.HandlerClasses
{
    class DrawHandler : AbstractHandler
    {
        private bool leftMouseButtonClicked = false;
        Canvas canvas = Canvas.GetCanvas();

        public DrawHandler(AbstractDiagramElementFactory diagramFactory)
        {
            currentFactory = diagramFactory;
        }

        public override void MouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                canvas.SetPenParameters(canvas.PenColor, canvas.PenSize);
                currentDiagramElement = currentFactory.GetElement(canvas.PenColor, canvas.PenSize);
                currentDiagramElement.StartPoint = e.Location;
                leftMouseButtonClicked = true;
            }
        }

        public override void MouseMove(Point point)
        {
            if (!(currentDiagramElement is null))
            {
                currentDiagramElement.EndPoint = point;
            }
        }

        public override void Paint()
        {
            if (leftMouseButtonClicked)
            {
                canvas.SetPenParameters(currentDiagramElement.ObjectPenColor, currentDiagramElement.ObjectPenWidth);
                canvas.graphics.Clear(canvas.pictureBox.BackColor);
                currentDiagramElement.Draw(canvas);
                canvas.RedrawElementsFromElementsList();
                canvas.SetPenParameters(currentDiagramElement.ObjectPenColor, currentDiagramElement.ObjectPenWidth);
            }
        }

        public override void MouseUp()
        {
            canvas.listAbstractDiagramElements.Add(currentDiagramElement);
            currentDiagramElement = null;
            leftMouseButtonClicked = false;
        }

        public override void MouseClick(MouseEventArgs e) { }

        public override AbstractDiagramElement ReturnElement()
        {
            return null;
        }
    }
}
