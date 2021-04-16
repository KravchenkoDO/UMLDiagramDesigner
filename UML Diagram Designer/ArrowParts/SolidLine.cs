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
            LineStyle = DashStyle.Solid;

            GetLine(LineStyle, startPoint, endPoint);

            _points = new List<Point>
            {
                StartPoint,
                EndPoint
            };
        }
    }
}
