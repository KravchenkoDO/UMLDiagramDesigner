using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.ArrowParts
{
    public class DiamondCap : AbstractCap
    {
        public DiamondCap()
        {
            GetCap();
        }

        protected override void GetCap()
        {
            AdjustableArrowCap arrowCap = new AdjustableArrowCap(4, 4, false);
            _cap = arrowCap;
        }
    }
}
