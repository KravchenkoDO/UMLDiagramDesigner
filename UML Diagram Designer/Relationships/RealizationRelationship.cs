using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.Relationships
{
    public class RealizationRelationship : AbstractRelationship
    {
        public RealizationRelationship(Color color, int width)
        {
            _pen = new Pen(color, width);
            AdjustableArrowCap realizationRelationshipCap = new AdjustableArrowCap(4,4);
            _pen.CustomEndCap = realizationRelationshipCap;
            _pen.DashStyle = DashStyle.Dash;
        }
        public override void Draw(Graphics graphics)
        {
            GraphicsPath _pathLine = new GraphicsPath();
            graphics.DrawLines(_pen, GetPoints().ToArray());
        }
    }
}
