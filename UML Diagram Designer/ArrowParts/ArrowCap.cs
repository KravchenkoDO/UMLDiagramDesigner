using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.ArrowParts
{
    public class ArrowCap : AbstractCap
    {
        public ArrowCap(Point lineEndPoint)
        {
            CapPoint = lineEndPoint;
            _points = new List<Point>
            {
                new Point(CapPoint.X, CapPoint.Y),
                new Point(CapPoint.X - 5, CapPoint.Y - 5),
                new Point(CapPoint.X, CapPoint.Y),
                new Point(CapPoint.X - 5, CapPoint.Y + 5),
                new Point(CapPoint.X, CapPoint.Y)
            };
            GetCap(_points);
        }
    }
}
