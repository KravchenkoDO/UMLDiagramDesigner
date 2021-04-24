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
        private bool leftMouseButtonClicked = false;
        Canvas canvas = Canvas.GetCanvas();
        public Point _pointForMove;

        public override void MouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (var element in canvas._listAbstractDiagramElements)
                {
                    if (!(element is null) && element.CheckIfTheObjectIsClicked(e.Location))
                    {
                        _currentDiagramElement = element;
                        canvas._listAbstractDiagramElements.Remove(element);
                        break;
                    }
                }
                _pointForMove = e.Location;
                leftMouseButtonClicked = true;
            }
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
            if (leftMouseButtonClicked)
            {
                if (!(_currentDiagramElement is null))
                {
                    canvas.SetPenParameters(_currentDiagramElement.ObjectPenColor, _currentDiagramElement.ObjectPenWidth);
                    canvas._graphics.Clear(canvas._pictureBox.BackColor);
                    _currentDiagramElement.Draw(canvas);

                    foreach (var element in canvas._listAbstractDiagramElements)
                    {
                        if (!(element is null))
                        {
                            canvas.SetPenParameters(element.ObjectPenColor, element.ObjectPenWidth);
                            element.Draw(canvas);
                        }
                    }
                }
            }
        }

        public override void MouseUp()
        {
            if (!(_currentDiagramElement is null))
            {
                canvas._listAbstractDiagramElements.Add(_currentDiagramElement);
            }
            
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
