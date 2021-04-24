using System.Drawing;
using System.Drawing.Drawing2D;

namespace UML_Diagram_Designer.ArrowParts
{
    public class DiamondCap : AbstractCap
    {
        public override CustomLineCap GetCap()
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

            return new CustomLineCap(null, graphicsPath);
        }
    }
}
