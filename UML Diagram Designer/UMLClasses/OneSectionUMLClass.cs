using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Tool.UMLClasses
{
    public class OneSectionUMLClass : AbstractUMLClass
    {
        public OneSectionUMLClass()
        {
            _pen = new Pen(Color.Blue, 8);
        }
        public override void DrawUMLClass(Graphics graphics, Point endPoint)
        {
            Width = endPoint.X - StartPoint.X;
            Height = endPoint.Y - StartPoint.Y;

            graphics.DrawPolygon(_pen, GetPoints().ToArray());
        }

        public override List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();

            points.Add(StartPoint);
            points.Add(new Point(StartPoint.X + Width, StartPoint.Y));
            points.Add(new Point(StartPoint.X + Width, StartPoint.Y + Height));
            points.Add(new Point(StartPoint.X, StartPoint.Y + Height));

            return points;
        }
    }
}
