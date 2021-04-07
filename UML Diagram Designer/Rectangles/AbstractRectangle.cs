using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.Rectangles
{
    public abstract class AbstractRectangle
    {
        protected Pen _pen;
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        

        public abstract void Draw(Graphics graphics);
    }
}
