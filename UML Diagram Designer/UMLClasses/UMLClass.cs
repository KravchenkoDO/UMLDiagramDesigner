using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_Designer.Interfaces;

namespace UML_Diagram_Designer.UMLClasses
{
    public class UMLClass:IMoveable,ISelectable
    {
        public Pen _pen = new Pen(Color.Black, 5);
        public Point StartPoint { set; get; }
        public Point EndPoint { set; get; }
        public int Width { set; get; }
        public int Height { set; get; }

        public UMLClass(Color color, int width)
        {
            _pen = new Pen(color, width);
        }

        public void DrawUMLClass(Graphics graphics) //int koef = 1, int classCount = 2)
        {
            Width = Math.Abs(EndPoint.X - StartPoint.X);
            Height = Math.Abs(EndPoint.Y - StartPoint.Y);

            graphics.DrawRectangle(_pen, StartPoint.X, StartPoint.Y, Width, Height);// * koef, _height * koef);
            graphics.DrawRectangle(_pen, StartPoint.X, StartPoint.Y, Width, Height / 4);
        }

        public bool CheckIfTheObjectIsClicked(Point point)
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
