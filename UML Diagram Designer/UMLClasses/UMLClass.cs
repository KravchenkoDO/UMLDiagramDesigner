using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UML_Diagram_Designer.UMLClasses
{
    public class UMLClass : AbstractUMLElement
    {
        public UMLClass(Color lineColor, float lineWidth)
        {
            _listForRect1Text = new List<string>() { "ClassName" };
            _listForRect2Text = new List<string>() { "Set Properties and fields" };
            _listForRect3Text = new List<string>() { "Set Methods" };
            ObjectPenColor = lineColor;
            ObjectPenWidth = lineWidth;
            _lineStyle = DashStyle.Solid;
        }
    }
}
