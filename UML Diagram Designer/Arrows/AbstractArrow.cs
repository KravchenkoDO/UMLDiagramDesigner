using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.Arrows
{
     public abstract class AbstractArrow
    {
        protected Pen _pen;
        protected GraphicsPath _pathForCustomLineEndCap;
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        protected List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();

            points.Add(StartPoint);
            int middleX = (StartPoint.X + EndPoint.X) / 2;

            points.Add(new Point(middleX, StartPoint.Y));
            points.Add(new Point(middleX, EndPoint.Y));
            points.Add(EndPoint);

            return points;
        }

        public abstract void Draw(Graphics graphics);
    }
}
