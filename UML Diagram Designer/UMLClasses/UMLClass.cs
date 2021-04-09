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
        public int width;
        public int height;

        public void DrawUMLClass(Graphics graphics, Point StartPoint)
        {
            width = 70;
            height = 100;

            graphics.DrawRectangle(_pen, StartPoint.X, StartPoint.Y, width, height);
            graphics.DrawRectangle(_pen, StartPoint.X, StartPoint.Y, width, height / 4);
        }
    }
}
