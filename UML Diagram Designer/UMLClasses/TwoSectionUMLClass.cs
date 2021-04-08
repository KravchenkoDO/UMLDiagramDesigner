using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Tool.UMLClasses
{
    public class TwoSectionUMLClass: AbstractUMLClass
    {
        public TwoSectionUMLClass()
        {
            _pen = new Pen(Color.Red, 8);
        }
        public override void DrawUMLClass(Graphics graphics, Point endPoint)
        {
            Width = endPoint.X - StartPoint.X;
            Height = endPoint.Y - StartPoint.Y;

            graphics.DrawRectangle(_pen, StartPoint.X, StartPoint.Y, Width, Height);
        }
    }
}
