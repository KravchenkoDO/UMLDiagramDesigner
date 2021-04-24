using System.Drawing;
using UML_Diagram_Designer.ArrowParts;

namespace UML_Diagram_Designer.Relationships
{
    public class CompositionRelationship : AbstractRelationship
    {
        public CompositionRelationship(Color lineColor, float lineWidth)
        {
            FilledDiamondCap filledDiamondCap = new FilledDiamondCap();
            SolidLine solidLine = new SolidLine();
            _cap = filledDiamondCap;
            _lineStyle = solidLine._lineStyle;
            ObjectPenColor = lineColor;
            ObjectPenWidth = lineWidth;
        }
    }
}
