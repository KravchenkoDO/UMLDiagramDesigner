using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_Designer.Interfaces;

namespace UML_Diagram_Designer
{
    public abstract class AbstractDiagramElement : IDrawable, ISelectable, IMoveable, IResizable, IChangeColors
    {
        public Color ObjectColor { get; set; }
        public int ObjectWidth { get; set; }

        public abstract bool CheckIfTheObjectIsClicked(Point point);

        public abstract void Move(int deltaX, int deltaY);
    }
}
