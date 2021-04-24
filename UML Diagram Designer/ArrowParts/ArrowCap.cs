using System.Drawing.Drawing2D;

namespace UML_Diagram_Designer.ArrowParts
{
    public class ArrowCap : AbstractCap
    {
        public override CustomLineCap GetCap()
        {
            return new AdjustableArrowCap(4, 4, false);
        }
    }
}
