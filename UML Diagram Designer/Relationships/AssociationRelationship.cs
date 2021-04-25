using System.Drawing;
using UML_Diagram_Designer.ArrowParts;

namespace UML_Diagram_Designer.Relationships
{
    public class AssociationRelationship : AbstractRelationship
    {
        public AssociationRelationship(Color lineColor, float lineWidth)
        {
            ArrowCap arrowCap = new ArrowCap();
            SolidLine solidLine = new SolidLine();
            cap = arrowCap;
            lineStyle = solidLine.lineStyle;
            ObjectPenColor = lineColor;
            ObjectPenWidth = lineWidth;
        }
    }
}
