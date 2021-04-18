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
    public class AssociationRelationship : AbstractRelationship
    {
        public AssociationRelationship(Color lineColor, float lineWidth)
        {
            ArrowCap arrowCap = new ArrowCap();
            SolidLine solidLine = new SolidLine();
            _cap = arrowCap._cap;
            _lineStyle = solidLine._lineStyle;
            ObjectColor = lineColor;
            ObjectWidth = lineWidth;
        }
    }
}
