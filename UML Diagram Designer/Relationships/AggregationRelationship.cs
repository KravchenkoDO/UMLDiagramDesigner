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
    public class AggregationRelationship : AbstractRelationship
    {
        public AggregationRelationship(Color lineColor, float lineWidth)
        {
            DiamondCap diamondCap = new DiamondCap();
            SolidLine solidLine = new SolidLine();
            _cap = diamondCap;
            _lineStyle = solidLine._lineStyle;
            ObjectPenColor = lineColor;
            ObjectPenWidth = lineWidth;
        }
    }
}
