using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UML_Diagram_Designer.Interfaces
{
   public interface IMoveable
    {
        void Move(int deltaX, int deltaY);
    }
}
