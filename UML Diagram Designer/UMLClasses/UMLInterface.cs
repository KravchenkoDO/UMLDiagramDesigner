using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace UML_Diagram_Designer.UMLClasses
{
    public class UMLInterface : AbstractUMLElement
    {
        public UMLInterface(Color lineColor, float lineWidth)
        {
            _listForRect1Text = new List<string>() { "InterfaceName" };
            _listForRect2Text = new List<string>() { "Set Methods" };
            _listForRect3Text = new List<string>() { "Have no Properties" };
            ObjectPenColor = lineColor;
            ObjectPenWidth = lineWidth;
            _lineStyle = DashStyle.Solid;
        }

        public override void Draw(Canvas painter)
        {
            painter._pen.DashStyle = _lineStyle;
            StringBuilder sbForRect1Text = new StringBuilder(string.Empty);
            StringBuilder sbForRect2Text = new StringBuilder(string.Empty);
            StringBuilder sbForRect3Text = new StringBuilder(string.Empty);

            foreach (var rowText in _listForRect1Text)
            {
                sbForRect1Text.AppendFormat("{0}\n", rowText);
            }
            foreach (var rowText in _listForRect2Text)
            {
                sbForRect2Text.AppendFormat("{0}\n", rowText);
            }
            foreach (var rowText in _listForRect3Text)
            {
                sbForRect3Text.AppendFormat("{0}\n", rowText);
            }

            CalculateClassCoordinates(_listForRect1Text, _listForRect2Text, _listForRect3Text);

            Rectangle rect1 = new Rectangle(_startPointRect1.X, _startPointRect1.Y, _width, _rect1Height);
            Rectangle rect2 = new Rectangle(_startPointRect2.X, _startPointRect2.Y, _width, _rect2Height);

            painter._graphics.DrawRectangle(painter._pen, rect1);
            painter._graphics.DrawRectangle(painter._pen, rect2);
            painter._graphics.DrawString(sbForRect1Text.ToString(), painter._font, painter._brush, rect1, strFormatForRect);
            painter._graphics.DrawString(sbForRect2Text.ToString(), painter._font, painter._brush, rect2, strFormatForRect);
        }
    }
}
