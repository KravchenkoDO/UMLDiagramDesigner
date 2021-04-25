using System.Drawing;
using UML_Diagram_Designer.ArrowParts;

namespace UML_Diagram_Designer.Relationships
{
    public class RealizationRelationship : AbstractRelationship
    {
        public RealizationRelationship(Color lineColor, float lineWidth)
        {
            FilledArrowCap filledArrowCap = new FilledArrowCap();
            DashLine dashLine = new DashLine();
            cap = filledArrowCap;
            lineStyle = dashLine.lineStyle;
            ObjectPenColor = lineColor;
            ObjectPenWidth = lineWidth;
        }
    }
}
