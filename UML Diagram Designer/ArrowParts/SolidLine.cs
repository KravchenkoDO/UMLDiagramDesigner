using System.Drawing.Drawing2D;

namespace UML_Diagram_Designer.ArrowParts
{
    public class SolidLine : AbstractLine
    {
        public SolidLine()
        {
            lineStyle = DashStyle.Solid;

            GetLine(lineStyle);
        }
    }
}
