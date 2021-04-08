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
        public RealizationRelationship()
        {
            _pen = new Pen(Color.Black, 6);
            _pen.CustomEndCap = CreateFilledArrowCap();
            _pen.DashStyle = DashStyle.Dash;
        }

        private CustomLineCap CreateFilledArrowCap()
        {
            _pathForCustomLineEndCap = new GraphicsPath();

            _pathForCustomLineEndCap.AddLine(new Point(0, 0), new Point(-3, -3));
            _pathForCustomLineEndCap.AddLine(new Point(-3, -3), new Point(0, -3));
            _pathForCustomLineEndCap.AddLine(new Point(0, -3), new Point(3, -3));
            _pathForCustomLineEndCap.AddLine(new Point(3, -3), new Point(0, 0));

            return new CustomLineCap(_pathForCustomLineEndCap, null);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(_pen, GetPoints().ToArray());
        }
    }
}
