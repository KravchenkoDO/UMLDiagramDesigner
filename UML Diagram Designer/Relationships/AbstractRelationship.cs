using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.Relationships
{
     public abstract class AbstractRelationship
    {
        protected Pen _pen;
        protected GraphicsPath _pathForCustomLineEndCap;
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        protected List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            points.Add(StartPoint);
            points.Add(EndPoint);
            return points;
        }

        public abstract void Draw(Graphics graphics);
    }
}
