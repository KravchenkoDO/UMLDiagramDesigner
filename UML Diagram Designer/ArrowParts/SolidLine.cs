using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.ArrowParts
{
    public class SolidLine : AbstractLine
    {
        public SolidLine(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            _points = new List<Point>
            {
                StartPoint,
                EndPoint
            };
            LineStyle = DashStyle.Solid;

            GetLine(_points);
        }
    }
}
