using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_Designer.Interfaces;

namespace UML_Diagram_Designer.Relationships
{
     public abstract class AbstractRelationship:IMoveable
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

        public bool IsItYou(Point point)
        {
            int xMax;
            int xMin;
            int yMax;
            int yMin;

            if (StartPoint.X > EndPoint.X)
            {
                xMax = StartPoint.X;
                xMin = EndPoint.X;
            }
            else
            {
                xMin = StartPoint.X;
                xMax = EndPoint.X;
            }

            if (StartPoint.Y > EndPoint.Y)
            {
                yMax = StartPoint.Y;
                yMin = EndPoint.Y;
            }
            else
            {
                yMin = StartPoint.Y;
                yMax = EndPoint.Y;
            }

            if (point.X <= xMax && point.X >= xMin
               && point.Y <= yMax && point.Y >= yMin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move(int deltaX, int deltaY)
        {
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
            EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
        }
    }
}
