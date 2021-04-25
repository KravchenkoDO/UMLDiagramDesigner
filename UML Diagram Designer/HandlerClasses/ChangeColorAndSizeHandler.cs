using System.Drawing;
using System.Windows.Forms;
using UML_Diagram_Designer.Relationships;
using UML_Diagram_Designer.FactoryClasses;

namespace UML_Diagram_Designer.HandlerClasses
{
    class ChangeColorAndSizeHandler : AbstractHandler
    {
        Canvas canvas = Canvas.GetCanvas();

        public ChangeColorAndSizeHandler() { }

        public ChangeColorAndSizeHandler(AbstractDiagramElementFactory editFactory)
        {
            currentFactory = editFactory;
        }

        public override void MouseClick(MouseEventArgs e)
        {
            foreach (var element in canvas.listAbstractDiagramElements)
            {
                if (element.CheckIfTheObjectIsClicked(e.Location))
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        if (!(currentFactory is null) && element is AbstractRelationship)
                        {
                            currentDiagramElement = currentFactory.GetElement(element.ObjectPenColor, element.ObjectPenWidth);
                            currentDiagramElement.StartPoint = element.StartPoint;
                            currentDiagramElement.EndPoint = element.EndPoint;
                            canvas.listAbstractDiagramElements.Remove(element);
                            canvas.graphics.Clear(Color.White);
                            canvas.listAbstractDiagramElements.Add(currentDiagramElement);
                            canvas.RedrawElementsFromElementsList();
                            break;
                        }
                        else if (currentFactory is null)
                        {
                            currentDiagramElement = element;
                            canvas.listAbstractDiagramElements.Remove(element);
                            canvas.graphics.Clear(Color.White);
                            currentDiagramElement.ObjectPenColor = canvas.PenColor;
                            currentDiagramElement.ObjectPenWidth = canvas.PenSize;
                            canvas.listAbstractDiagramElements.Add(currentDiagramElement);
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
