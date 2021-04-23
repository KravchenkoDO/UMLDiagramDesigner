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
    public class InheritanceRelationship : AbstractRelationship
    {
        public InheritanceRelationship(Color lineColor, float lineWidth)
        {
            FilledArrowCap filledArrowCap = new FilledArrowCap();
            SolidLine solidLine = new SolidLine();
            _cap = filledArrowCap._cap;
            _lineStyle = solidLine._lineStyle;
            ObjectPenColor = lineColor;
            ObjectPenWidth = lineWidth;
        }
    }
}
