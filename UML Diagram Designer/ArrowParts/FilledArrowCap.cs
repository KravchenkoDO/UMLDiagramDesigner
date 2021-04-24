using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.ArrowParts
{
    public class FilledArrowCap : AbstractCap
    {
        public FilledArrowCap()
        {
            GetCap();
        }

        public override CustomLineCap GetCap()
        {
            return new AdjustableArrowCap(4, 4);
        }
    }
}
