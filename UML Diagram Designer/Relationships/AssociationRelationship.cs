using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.Relationships
{
    public class AssociationRelationship : AbstractRelationship
    {
        public AssociationRelationship()
        {
            _pen = new Pen(Color.Black, 6);
            AdjustableArrowCap associationRelationshipCap = new AdjustableArrowCap(4, 4, false);
            _pen.CustomEndCap = associationRelationshipCap;
            _pen.DashStyle = DashStyle.Solid;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(_pen, GetPoints().ToArray());
        }
    }
}
