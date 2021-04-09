using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.Relationships
{
    public class AggregationRelationship : AbstractRelationship
    {
        public AggregationRelationship()
        {
            _pen = new Pen(Color.Black, 6);
            _pen.CustomEndCap = CreateNotFilledDiamondCap();
            _pen.DashStyle = DashStyle.Solid;
        }

        private CustomLineCap CreateNotFilledDiamondCap()
        {
            _pathForCustomLineEndCap = new GraphicsPath();
            Point[] points = new Point[]
            {
                new Point(0, 0),
                new Point(2, 3),
                new Point(0, 6),
                new Point(-2, 3),
                new Point(0, 0)
            };

            _pathForCustomLineEndCap.AddLines(points);

            return new CustomLineCap(null, _pathForCustomLineEndCap);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(_pen, GetPoints().ToArray());
        }
    }
}
