using System.Drawing;
using UML_Diagram_Designer.UMLClasses;

namespace UML_Diagram_Designer.FactoryClasses.ClassBlockFactories
{
    public class UMLInterfaceFactory : AbstractDiagramElementFactory
    {
        public override AbstractDiagramElement GetElement(Color lineColor, float lineWidth)
        {
            return new UMLInterface(lineColor, lineWidth);
        }
    }
}
