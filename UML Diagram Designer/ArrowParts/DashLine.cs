using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.ArrowParts
{
    public class DashLine : AbstractLine
    {
        public DashLine(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            _points = new List<Point>
            {
                StartPoint,
                EndPoint
            };
            LineStyle = DashStyle.Dash;

            GetLine(_points);
        }
    }
}
