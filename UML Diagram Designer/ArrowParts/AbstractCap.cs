using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.ArrowParts
{
    public abstract class AbstractCap
    {
        protected List<Point> _points;
        protected Point CapPoint { get; set; }
        protected GraphicsPath GrPath { get; set; }

        protected void GetCap(List<Point> points)
        {
            GrPath = new GraphicsPath();
            GrPath.AddLines(points.ToArray());
        }
    }
}
