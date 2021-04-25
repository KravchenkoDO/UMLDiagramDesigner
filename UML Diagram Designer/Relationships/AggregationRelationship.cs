using System.Drawing;
using UML_Diagram_Designer.ArrowParts;

namespace UML_Diagram_Designer.Relationships
{
    public class AggregationRelationship : AbstractRelationship
    {
        public AggregationRelationship(Color lineColor, float lineWidth)
        {
            DiamondCap diamondCap = new DiamondCap();
            SolidLine solidLine = new SolidLine();
            cap = diamondCap;
            lineStyle = solidLine.lineStyle;
            ObjectPenColor = lineColor;
            ObjectPenWidth = lineWidth;
        }
    }
}
