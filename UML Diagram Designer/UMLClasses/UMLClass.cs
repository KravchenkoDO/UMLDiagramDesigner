using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.UMLClasses
{
    public class UMLClass
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
    }
}
