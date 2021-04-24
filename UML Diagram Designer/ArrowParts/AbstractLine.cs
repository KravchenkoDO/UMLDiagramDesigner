using System.Drawing.Drawing2D;

namespace UML_Diagram_Designer.ArrowParts
{
    public abstract class AbstractLine
    {
        public DashStyle _lineStyle;

        protected void GetLine(DashStyle lineStyle)
        {
            _lineStyle = lineStyle;
        }
    }
}
