using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.UMLClasses
{
    public class UMLInterface : AbstractUMLElement
    {
        public UMLInterface(Color lineColor, float lineWidth)
        {
            _listForRect1Text = new List<string>() { "«C# Interface»", "EnterInterfaceName" };
            _listForRect2Text = new List<string>() { "Set Properties" };
            _listForRect3Text = new List<string>() { "Set Methods" };
            ObjectPenColor = lineColor;
            ObjectPenWidth = lineWidth;
            _lineStyle = DashStyle.Solid;
        }
    }
}
