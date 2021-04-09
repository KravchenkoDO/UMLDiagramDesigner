using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_Designer.UMLClass;

namespace UML_Diagram_Designer.UMLClasses
{
    public class ThreeSectionUMLClass: AbstractUMLClass
    {
        public ThreeSectionUMLClass()
        {
            _pen = new Pen(Color.Black, 5);
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

            points.Add(StartPoint);//1
            points.Add(new Point(StartPoint.X + Width, StartPoint.Y));//2
            points.Add(new Point(StartPoint.X + Width, (StartPoint.Y + Height) / 7));//3
            points.Add(new Point(StartPoint.X, (StartPoint.Y + Height) / 7));//4
            points.Add(StartPoint);//1
            points.Add(new Point(StartPoint.X, (StartPoint.Y + Height) / 2));//6
            points.Add(new Point(StartPoint.X + Width, (StartPoint.Y + Height) / 2));//5
            points.Add(new Point(StartPoint.X + Width, (StartPoint.Y + Height) / 7));//3
            points.Add(new Point(StartPoint.X + Width, StartPoint.Y + Height));//8
            points.Add(new Point(StartPoint.X, StartPoint.Y + Height));//7
            points.Add(new Point(StartPoint.X, (StartPoint.Y + Height) / 2));//6
            return points;
        }
    }
}
