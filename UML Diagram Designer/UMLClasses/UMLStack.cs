using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace UML_Diagram_Designer.UMLClasses
{
    public class UMLStack : AbstractUMLElement
    {
        public UMLStack(Color lineColor, float lineWidth)
        {
            listForRect1Text = new List<string>() { "ClassesName" };
            listForRect2Text = new List<string>() { "Set Properties and fields" };
            listForRect3Text = new List<string>() { "Set Methods" };
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

            Rectangle rect1 = new Rectangle(startPointRect1.X - 20, startPointRect1.Y - 20, width, height);
            Rectangle rect2 = new Rectangle(startPointRect1.X - 10, startPointRect1.Y - 10, width, height);
            Rectangle rect3 = new Rectangle(startPointRect1.X, startPointRect1.Y, width, rect1Height);
            Rectangle rect4 = new Rectangle(startPointRect2.X, startPointRect2.Y, width, rect2Height);
            Rectangle rect5 = new Rectangle(startPointRect3.X, startPointRect3.Y, width, rect3Height);

            painter.graphics.DrawRectangle(painter.pen, rect1);
            painter.graphics.FillRectangle(Brushes.White, rect1);
            painter.graphics.DrawRectangle(painter.pen, rect2);
            painter.graphics.FillRectangle(Brushes.White, rect2);
            painter.graphics.DrawRectangle(painter.pen, rect3);
            painter.graphics.FillRectangle(Brushes.White, rect3);
            painter.graphics.DrawRectangle(painter.pen, rect4);
            painter.graphics.FillRectangle(Brushes.White, rect4);
            painter.graphics.DrawRectangle(painter.pen, rect5);
            painter.graphics.FillRectangle(Brushes.White, rect5);
            painter.graphics.DrawString(sbForRect1Text.ToString(), painter.font, painter.brush, rect3);
            painter.graphics.DrawString(sbForRect2Text.ToString(), painter.font, painter.brush, rect4);
            painter.graphics.DrawString(sbForRect3Text.ToString(), painter.font, painter.brush, rect5);
        }
    }
}
