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
    class MoveHandler : AbstractHandler
    {
        public Canvas canvas = Canvas.GetCanvas();
        public Point _pointForMove;

        public override void MouseDown(Point point)
        {
            foreach (var element in canvas._listAbstractDiagramElements)
            {
                if (element.CheckIfTheObjectIsClicked(point))
                {
                    _currentDiagramElement = element;
                    canvas._listAbstractDiagramElements.Remove(element);
                    break;
                }
            }
            _pointForMove = point;
        }

        public override void MouseMove(Point point)
        {
            if (!(_currentDiagramElement is null))
            {
                _currentDiagramElement.Move(point.X - _pointForMove.X, point.Y - _pointForMove.Y);
                _pointForMove = point;
            }
        }

        public override void Paint()
        {
            if (!(_currentDiagramElement is null))
            {
                canvas.SetPenParameters(_currentDiagramElement.ObjectPenColor, _currentDiagramElement.ObjectPenWidth);
                canvas._graphics.Clear(canvas._pictureBox.BackColor);
                _currentDiagramElement.Draw(canvas);

                foreach (var element in canvas._listAbstractDiagramElements)
                {
                    canvas.SetPenParameters(element.ObjectPenColor, element.ObjectPenWidth);
                    element.Draw(canvas);
                }
            }
            
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
