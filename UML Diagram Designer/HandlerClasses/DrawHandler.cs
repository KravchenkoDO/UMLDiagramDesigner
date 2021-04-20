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
    class DrawHandler
    {
        public Canvas canvas = Canvas.GetCanvas();
        public AbstractDiagramElement _currentDiagramElement;
        public DrawHandler(AbstractDiagramElementFactory diagramFactory)
        {
            _currentDiagramElement = diagramFactory.GetElement(canvas.PenColor, canvas.PenSize);
        }

        public void MouseClick(Point point)
        {
            throw new NotImplementedException();
        }

        public void MouseDown(Point point)
        {
            canvas.SetPenParameters(colorDialog.Color, thicknessTrackBar.Value);
            _currentDiagramElement = _currentFactory.GetElement(canvas.PenColor, canvas.PenSize);
            _currentDiagramElement.StartPoint = point;
        }

        public void MouseMove(Point point)
        {
            throw new NotImplementedException();
        }

        public void MouseUp(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
