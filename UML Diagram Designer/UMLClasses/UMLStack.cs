using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.UMLClasses
{
    public class UMLStack : AbstractUMLElement
    {
        public UMLStack(Color lineColor, float lineWidth)
        {
            _listForRect1Text = new List<string>() { "«C# Classes»", "ClassesName" };
            _listForRect2Text = new List<string>() { "Set Properties and fields" };
            _listForRect3Text = new List<string>() { "Set Methods" };
            ObjectPenColor = lineColor;
            ObjectPenWidth = lineWidth;
        }
        public override void Draw(Canvas painter)
        {
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

            Rectangle rect1_1 = new Rectangle(_startPointRect1.X - 20, _startPointRect1.Y - 20, _width, _height);
            Rectangle rect1_2 = new Rectangle(_startPointRect1.X - 10, _startPointRect1.Y - 10, _width, _height);
            Rectangle rect1 = new Rectangle(_startPointRect1.X, _startPointRect1.Y, _width, _rect1Height);
            Rectangle rect2 = new Rectangle(_startPointRect2.X, _startPointRect2.Y, _width, _rect2Height);
            Rectangle rect3 = new Rectangle(_startPointRect3.X, _startPointRect3.Y, _width, _rect3Height);

            painter._graphics.DrawRectangle(painter._pen, rect1_1);
            painter._graphics.FillRectangle(Brushes.White, rect1_1);
            painter._graphics.DrawRectangle(painter._pen, rect1_2);
            painter._graphics.FillRectangle(Brushes.White, rect1_2);
            painter._graphics.DrawRectangle(painter._pen, rect1);
            painter._graphics.FillRectangle(Brushes.White, rect1);
            painter._graphics.DrawRectangle(painter._pen, rect2);
            painter._graphics.FillRectangle(Brushes.White, rect2);
            painter._graphics.DrawRectangle(painter._pen, rect3);
            painter._graphics.FillRectangle(Brushes.White, rect3);
            painter._graphics.DrawString(sbForRect1Text.ToString(), painter._font, painter._brush, rect1);
            painter._graphics.DrawString(sbForRect2Text.ToString(), painter._font, painter._brush, rect2);
            painter._graphics.DrawString(sbForRect3Text.ToString(), painter._font, painter._brush, rect3);
        }
    }
}
