using System.Drawing.Drawing2D;

namespace UML_Diagram_Designer.ArrowParts
{
    public class FilledArrowCap : AbstractCap
    {
        public override CustomLineCap GetCap()
        {
            return new AdjustableArrowCap(4, 4);
        }
    }
}
