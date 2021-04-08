using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Tool.UMLClasses
{
    public abstract class AbstractUMLClass
    {
        public Pen _pen;
        public Point StartPoint { set; get; }
        public int Width;
        public int Height;
        public abstract void DrawUMLClass(Graphics graphics, Point endPoint);

        public abstract List<Point> GetPoints();
    }

}
