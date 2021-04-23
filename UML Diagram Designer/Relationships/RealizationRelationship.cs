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
    public class RealizationRelationship : AbstractRelationship
    {
        public RealizationRelationship(Color lineColor, float lineWidth)
        {
            FilledArrowCap filledArrowCap = new FilledArrowCap();
            DashLine dashLine = new DashLine();
            _cap = filledArrowCap;
            _lineStyle = dashLine._lineStyle;
            ObjectPenColor = lineColor;
            ObjectPenWidth = lineWidth;
        }
    }
}
