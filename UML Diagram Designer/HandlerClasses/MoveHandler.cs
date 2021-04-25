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
        public Point pointForMove;

        public override void MouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (var element in canvas.listAbstractDiagramElements)
                {
                    if (!(element is null) && element.CheckIfTheObjectIsClicked(e.Location))
                    {
                        currentDiagramElement = element;
                        canvas.listAbstractDiagramElements.Remove(element);
                        break;
                    }
                }
                pointForMove = e.Location;
                leftMouseButtonClicked = true;
            }
        }

        public override void MouseMove(Point point)
        {
            if (!(currentDiagramElement is null))
            {
                currentDiagramElement.Move(point.X - pointForMove.X, point.Y - pointForMove.Y);
                pointForMove = point;
            }
        }

        public override void Paint()
        {
            if (leftMouseButtonClicked)
            {
                if (!(currentDiagramElement is null))
                {
                    canvas.SetPenParameters(currentDiagramElement.ObjectPenColor, currentDiagramElement.ObjectPenWidth);
                    canvas.graphics.Clear(canvas.pictureBox.BackColor);
                    currentDiagramElement.Draw(canvas);

                    foreach (var element in canvas.listAbstractDiagramElements)
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
            if (!(currentDiagramElement is null))
            {
                canvas.listAbstractDiagramElements.Add(currentDiagramElement);
            }
            
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
