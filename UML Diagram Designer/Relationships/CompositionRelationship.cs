using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.Relationships
{
    public class CompositionRelationship : AbstractRelationship
    {
        public CompositionRelationship()
        {
            _pen = new Pen(Color.Black, 6);
            _pen.CustomEndCap = CreateFilledDiamondCap();
            _pen.DashStyle = DashStyle.Solid;
        }
        private CustomLineCap CreateFilledDiamondCap()
        {
            _pathForCustomLineEndCap = new GraphicsPath();
            PointF[] points = new PointF[]
            {
                new PointF(0, -0.02f),
                new PointF(2, 3),
                new PointF(0, 6),
                new PointF(-2, 3),
                new PointF(0, -0.02f)
            };
            _pathForCustomLineEndCap.AddLines(points);
            return new CustomLineCap(_pathForCustomLineEndCap, null);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(_pen, GetPoints().ToArray());
        }
    }
}
