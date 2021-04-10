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
        public int _width { set; get; }
        public int _height { set; get; }

        public void DrawUMLClass(Graphics graphics) //int koef = 1, int classCount = 2)
        {
            _width = Math.Abs(EndPoint.X - StartPoint.X);
            _height = Math.Abs(EndPoint.Y - StartPoint.Y);

            graphics.DrawRectangle(_pen, StartPoint.X, StartPoint.Y, _width, _height);// * koef, _height * koef);
            graphics.DrawRectangle(_pen, StartPoint.X, StartPoint.Y, _width, _height / 4);
        }
    }
}
