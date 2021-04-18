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
                new PointF(0, -1),
                new PointF(2, 2),
                new PointF(0, 5),
                new PointF(-2, 2),
                new PointF(0, -1)
            };

            graphicsPath.AddLines(points);

            _cap = new CustomLineCap(graphicsPath, null);
        }
    }
}
