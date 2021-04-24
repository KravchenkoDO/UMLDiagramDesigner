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

        public override CustomLineCap GetCap()
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            Point[] points = new Point[]
            {
                new Point(0, -1),
                new Point(2, 2),
                new Point(0, 5),
                new Point(-2, 2),
                new Point(0, -1)
            };

            graphicsPath.AddLines(points);

            return new CustomLineCap(graphicsPath, null);
        }
    }
}
