using System.Drawing;
using System.Drawing.Drawing2D;

namespace UML_Diagram_Designer.ArrowParts
{
    public class FilledDiamondCap : AbstractCap
    {
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
