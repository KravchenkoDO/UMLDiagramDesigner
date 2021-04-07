using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.Rectangles
{
    public class ClassBox : AbstractRectangle
    {
        Rectangle rectangle;
        public ClassBox()
        {
            _pen = new Pen(Color.Black, 6);
            _pen.DashStyle = DashStyle.Solid;

            Size size = new Size(EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y);
            Rectangle rectangle = new Rectangle(StartPoint, size);
            
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(_pen, rectangle);
        }

    }
    
}
