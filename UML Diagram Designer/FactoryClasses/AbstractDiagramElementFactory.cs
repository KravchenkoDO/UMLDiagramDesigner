using System.Drawing;

namespace UML_Diagram_Designer.FactoryClasses
{
    public abstract class AbstractDiagramElementFactory
    {
        public abstract AbstractDiagramElement GetElement(Color lineColor, float lineWidth);
    }
}
