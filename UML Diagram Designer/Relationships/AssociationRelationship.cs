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
        public AssociationRelationship()
        {
            ArrowCap arrowCap = new ArrowCap();
            SolidLine solidLine = new SolidLine();
            _cap = arrowCap._cap;
            _lineStyle = solidLine._lineStyle;
        }

        public override void Draw(Graphics graphics)
        {
            Pen _pen = new Pen(Color.Black, 5);
            _pen.CustomEndCap = _cap;
            _pen.DashStyle = _lineStyle;
            graphics.DrawLine(_pen, StartPoint, EndPoint);
        }
    }
}
