using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_Designer.ArrowParts;

namespace UML_Diagram_Designer.Relationships
{
    public class CompositionRelationship : AbstractRelationship
    {
        public CompositionRelationship(Color lineColor, float lineWidth)
        {
            FilledDiamondCap filledDiamondCap = new FilledDiamondCap();
            SolidLine solidLine = new SolidLine();
            _cap = filledDiamondCap._cap;
            _lineStyle = solidLine._lineStyle;
            ObjectColor = lineColor;
            ObjectWidth = lineWidth;
        }
    }
}
