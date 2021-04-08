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

            graphics.DrawRectangle(_pen, StartPoint.X, StartPoint.Y, Width, Height);
        }
    }
}
