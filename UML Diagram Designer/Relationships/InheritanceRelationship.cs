using System.Drawing;
using UML_Diagram_Designer.ArrowParts;

namespace UML_Diagram_Designer.Relationships
{
    public class InheritanceRelationship : AbstractRelationship
    {
        public InheritanceRelationship(Color lineColor, float lineWidth)
        {
            FilledArrowCap filledArrowCap = new FilledArrowCap();
            SolidLine solidLine = new SolidLine();
            cap = filledArrowCap;
            lineStyle = solidLine.lineStyle;
            ObjectPenColor = lineColor;
            ObjectPenWidth = lineWidth;
        }
    }
}
