using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.Relationships
{
    public class InheritanceRelationship : AbstractRelationship
    {
        public InheritanceRelationship(Color color, int width)
        {
            _pen = new Pen(color, width);
            AdjustableArrowCap inheritanceRelationshipCap = new AdjustableArrowCap(4, 4);
            _pen.CustomEndCap = inheritanceRelationshipCap;
            _pen.DashStyle = DashStyle.Solid;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(_pen, GetPoints().ToArray());
        }
    }
}
