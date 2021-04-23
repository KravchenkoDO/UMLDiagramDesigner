using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_Designer.Relationships;
using UML_Diagram_Designer.FactoryClasses;

namespace UML_Diagram_Designer.HandlerClasses
{
    class ChangeColorAndSizeHandler : AbstractHandler
    {
        public Canvas canvas = Canvas.GetCanvas();

        public ChangeColorAndSizeHandler() { }
        public ChangeColorAndSizeHandler(AbstractDiagramElementFactory editFactory)
        {
            _currentFactory = editFactory;
        }

        public override void MouseClick(MouseEventArgs e)
        {
            foreach (var element in canvas._listAbstractDiagramElements)
            {
                if (element.CheckIfTheObjectIsClicked(e.Location))
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        if (!(_currentFactory is null) && element is AbstractRelationship)
                        {
                            _currentDiagramElement = _currentFactory.GetElement(element.ObjectPenColor, element.ObjectPenWidth);
                            _currentDiagramElement.StartPoint = element.StartPoint;
                            _currentDiagramElement.EndPoint = element.EndPoint;
                            canvas._listAbstractDiagramElements.Remove(element);
                            canvas._graphics.Clear(Color.White);
                            canvas._listAbstractDiagramElements.Add(_currentDiagramElement);
                            canvas.RedrawElementsFromElementsList();
                            break;
                        }
                        else if(_currentFactory is null)
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
