using System.Drawing;
using UML_Diagram_Designer.Relationships;

namespace UML_Diagram_Designer.FactoryClasses.RelationshipFactories
{
    class CompositionRelationshipFactory : AbstractDiagramElementFactory
    {
        public override AbstractDiagramElement GetElement(Color lineColor, float lineWidth)
        {
            return new CompositionRelationship(lineColor, lineWidth);
        }
    }
}
