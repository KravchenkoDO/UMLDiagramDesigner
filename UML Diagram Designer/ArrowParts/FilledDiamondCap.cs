using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.ArrowParts
{
    public class FilledDiamondCap : AbstractCap
    {
        public FilledDiamondCap()
        {
            GetCap();
        }

        protected override void GetCap()
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            PointF[] points = new PointF[]
            {
                new PointF(0, -0.02f),
                new PointF(2, 3),
                new PointF(0, 6),
                new PointF(-2, 3),
                new PointF(0, -0.02f)
            };

            graphicsPath.AddLines(points);

            _cap = new CustomLineCap(graphicsPath, null);
        }
    }
}
