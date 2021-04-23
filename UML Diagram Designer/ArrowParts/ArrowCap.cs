using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.ArrowParts
{
    public class ArrowCap : AbstractCap
    {
       
        public ArrowCap()
        {
            GetCap();
        }

        protected override void GetCap()
        {
            _cap = new AdjustableArrowCap(4, 4, false);
        }
    }
}
