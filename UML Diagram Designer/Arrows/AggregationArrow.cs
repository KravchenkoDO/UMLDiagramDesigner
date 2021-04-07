using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.Arrows
{
    public class AggregationArrow : AbstractArrow
    {
        public AggregationArrow()
        {
            _pen = new Pen(Color.Black, 6);
            _pen.CustomEndCap = CreateNotFilledDiamondCap();
            _pen.DashStyle = DashStyle.Solid;
        }

        private CustomLineCap CreateNotFilledDiamondCap()
        {
            _pathForCustomLineEndCap = new GraphicsPath();

            Point point1 = new Point(0, 0);
            Point point2 = new Point(-2, -3);
            Point point3 = new Point(0, -6);
            Point point4 = new Point(2, -3);

            Point[] points = new Point[]
            {
                point1,
                point2,
                point3,
                point4
            };

            //_pathForCustomLineEndCap.AddLine(new Point(0, 0), new Point(-2, -3));
            //_pathForCustomLineEndCap.AddLine(new Point(-2, -3), new Point(0, -6));
            //_pathForCustomLineEndCap.AddLine(new Point(0, -6), new Point(2, -3));
            //_pathForCustomLineEndCap.AddLine(new Point(2, -3), new Point(0, 0));

            _pathForCustomLineEndCap.AddPolygon(points);

            return new CustomLineCap(null, _pathForCustomLineEndCap);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(_pen, GetPoints().ToArray());
        }
    }
}
