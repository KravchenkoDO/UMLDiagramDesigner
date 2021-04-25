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
            _currentFactory = diagramFactory;
        }

        public override void MouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                canvas.SetPenParameters(canvas.PenColor, canvas.PenSize);
                _currentDiagramElement = _currentFactory.GetElement(canvas.PenColor, canvas.PenSize);
                _currentDiagramElement.StartPoint = e.Location;
                leftMouseButtonClicked = true;
            }
        }

        public override void MouseMove(Point point)
        {
            if (!(_currentDiagramElement is null))
            {
                _currentDiagramElement.EndPoint = point;
            }
        }

        public override void Paint()
        {
            if (leftMouseButtonClicked)
            {
                canvas.SetPenParameters(_currentDiagramElement.ObjectPenColor, _currentDiagramElement.ObjectPenWidth);
                canvas.graphics.Clear(canvas.pictureBox.BackColor);
                _currentDiagramElement.Draw(canvas);
                canvas.RedrawElementsFromElementsList();
                canvas.SetPenParameters(_currentDiagramElement.ObjectPenColor, _currentDiagramElement.ObjectPenWidth);
            }
        }

        public override void MouseUp()
        {
            canvas.listAbstractDiagramElements.Add(_currentDiagramElement);
            _currentDiagramElement = null;
            leftMouseButtonClicked = false;
        }

        public override void MouseClick(MouseEventArgs e) { }

        public override AbstractDiagramElement ReturnElement()
        {
            return null;
        }
    }
}
