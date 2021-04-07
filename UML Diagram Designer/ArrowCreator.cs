using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer
{
    public class Arrow
    {
        private GraphicsPath _pathForCustomLineEndCap;
        public CustomLineCap NotFilledArrow { get; private set; }
        public CustomLineCap NotFilledDiamond { get; private set; }
        public CustomLineCap FilledArrow { get; private set; }
        public CustomLineCap FilledDiamond { get; private set; }

        public Arrow(Graphics graphics)
        {
            NotFilledArrow = CreateNotFilledArrowCap();
            NotFilledDiamond = CreateNotFilledDiamondCap(graphics);
            FilledArrow = CreateFilledArrowCap();
            FilledDiamond = CreateFilledDiamondCap();
        }

        private CustomLineCap CreateNotFilledArrowCap()
        {
            _pathForCustomLineEndCap = new GraphicsPath();

            _pathForCustomLineEndCap.AddLine(new Point(0, 0), new Point(-3, -3));
            _pathForCustomLineEndCap.AddLine(new Point(-3, -3), new Point(0, 0));
            _pathForCustomLineEndCap.AddLine(new Point(0, 0), new Point(3, -3));

            return new CustomLineCap(null, _pathForCustomLineEndCap);
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

        private CustomLineCap CreateNotFilledDiamondCap(Graphics graphics)
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

            using (Brush b = new SolidBrush(Color.White))
                graphics.FillPath(b, _pathForCustomLineEndCap);


            return new CustomLineCap(null, _pathForCustomLineEndCap);
        }

        private CustomLineCap CreateFilledDiamondCap()
        {
            _pathForCustomLineEndCap = new GraphicsPath();

            _pathForCustomLineEndCap.AddLine(new PointF(0.0f, 0.0f), new PointF(-2, -3));
            _pathForCustomLineEndCap.AddLine(new PointF(-2, -3), new PointF(0, -6));
            _pathForCustomLineEndCap.AddLine(new PointF(0, -6), new PointF(2, -3));
            _pathForCustomLineEndCap.AddLine(new PointF(2, -3), new PointF(0.0f, 0.0f));

            return new CustomLineCap(_pathForCustomLineEndCap, null);
        }


    }
}
