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
            listForRect1Text = new List<string>() { "InterfaceName" };
            listForRect2Text = new List<string>() { "Set Methods" };
            listForRect3Text = new List<string>() { "Have no Properties" };
            ObjectPenColor = lineColor;
            ObjectPenWidth = lineWidth;
            lineStyle = DashStyle.Solid;
        }

        public override void Draw(Canvas painter)
        {
            painter.pen.DashStyle = lineStyle;
            StringBuilder sbForRect1Text = new StringBuilder(string.Empty);
            StringBuilder sbForRect2Text = new StringBuilder(string.Empty);
            StringBuilder sbForRect3Text = new StringBuilder(string.Empty);

            foreach (var rowText in listForRect1Text)
            {
                sbForRect1Text.AppendFormat("{0}\n", rowText);
            }
            foreach (var rowText in listForRect2Text)
            {
                sbForRect2Text.AppendFormat("{0}\n", rowText);
            }
            foreach (var rowText in listForRect3Text)
            {
                sbForRect3Text.AppendFormat("{0}\n", rowText);
            }

            CalculateClassCoordinates(listForRect1Text, listForRect2Text, listForRect3Text);

            Rectangle rect1 = new Rectangle(startPointRect1.X, startPointRect1.Y, width, rect1Height);
            Rectangle rect2 = new Rectangle(startPointRect2.X, startPointRect2.Y, width, rect2Height);

            painter.graphics.DrawRectangle(painter.pen, rect1);
            painter.graphics.DrawRectangle(painter.pen, rect2);
            painter.graphics.DrawString(sbForRect1Text.ToString(), painter.font, painter.brush, rect1, strFormatForRect);
            painter.graphics.DrawString(sbForRect2Text.ToString(), painter.font, painter.brush, rect2, strFormatForRect);
        }
    }
}
