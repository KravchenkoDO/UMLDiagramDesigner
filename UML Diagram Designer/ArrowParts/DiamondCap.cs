using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.ArrowParts
{
    public class DiamondCap : AbstractCap
    {
        public DiamondCap()
        {
            GetCap();
        }

        protected override void GetCap()
        {
            GraphicsPath graphicsPath = new GraphicsPath();

            Point[] points = new Point[]
            {
                new Point(0, 0),
                new Point(2, 3),
                new Point(0, 6),
                new Point(-2, 3),
                new Point(0, 0)
            };

            graphicsPath.AddLines(points);

            _cap = new CustomLineCap(null, graphicsPath);
        }
    }
}
