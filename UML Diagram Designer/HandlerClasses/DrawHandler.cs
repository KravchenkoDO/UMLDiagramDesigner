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
    class DrawHandler : AbstractHandler
    {
        public Canvas canvas = Canvas.GetCanvas();

        public DrawHandler(AbstractDiagramElementFactory diagramFactory)
        {
            _currentFactory = diagramFactory;
        }

        public override void MouseDown(Point point)
        {
            canvas.SetPenParameters(canvas.PenColor, canvas.PenSize);
            _currentDiagramElement = _currentFactory.GetElement(canvas.PenColor, canvas.PenSize);
            _currentDiagramElement.StartPoint = point;
        }

        public override void MouseMove(Point point)
        {
            if(!(_currentDiagramElement is null))
            {
                _currentDiagramElement.EndPoint = point;
            }
        }

        public override void Paint()
        {
            canvas.SetPenParameters(_currentDiagramElement.ObjectPenColor, _currentDiagramElement.ObjectPenWidth);
            canvas._graphics.Clear(canvas._pictureBox.BackColor);
            _currentDiagramElement.Draw(canvas);
            canvas.RedrawElementsFromElementsList();
            canvas.SetPenParameters(_currentDiagramElement.ObjectPenColor, _currentDiagramElement.ObjectPenWidth);
        }

        public override void MouseUp()
        {
            canvas._listAbstractDiagramElements.Add(_currentDiagramElement);
            _currentDiagramElement = null;
        }

        public override void MouseClick(Point point) { }

        public override AbstractDiagramElement ReturnElement()
        {
            throw new NotImplementedException();
        }
    }
}
