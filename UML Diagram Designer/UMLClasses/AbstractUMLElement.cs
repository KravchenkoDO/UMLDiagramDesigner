using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace UML_Diagram_Designer.UMLClasses
{
    public abstract class AbstractUMLElement : AbstractDiagramElement
    {
        const int widthBuffer = 5;
        const int heightYBuffer = 5;
        public int width = 80;
        public int height = 80;
        public DashStyle lineStyle;

        public Point startPointRect1;
        public Point startPointRect2;
        public Point startPointRect3;

        public int rect1Height;
        public int rect2Height;
        public int rect3Height;
        public int rect1Width;
        public int rect2Width;
        public int rect3Width;

        public List<string> listForRect1Text;
        public List<string> listForRect2Text;
        public List<string> listForRect3Text;

        public StringFormat strFormatForRect = new StringFormat();

        public StringBuilder sbForRect1Text = new StringBuilder(string.Empty);
        public StringBuilder sbForRect2Text = new StringBuilder(string.Empty);
        public StringBuilder sbForRect3Text = new StringBuilder(string.Empty);

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
            Rectangle rect3 = new Rectangle(startPointRect3.X, startPointRect3.Y, width, rect3Height);

            painter.graphics.DrawRectangle(painter.pen, rect1);
            painter.graphics.DrawRectangle(painter.pen, rect2);
            painter.graphics.DrawRectangle(painter.pen, rect3);
            painter.graphics.DrawString(sbForRect1Text.ToString(), painter.font, painter.brush, rect1, strFormatForRect);
            painter.graphics.DrawString(sbForRect2Text.ToString(), painter.font, painter.brush, rect2, strFormatForRect);
            painter.graphics.DrawString(sbForRect3Text.ToString(), painter.font, painter.brush, rect3, strFormatForRect);
        }

        public EnumSections select;
        public AbstractUMLElement()
        {
            strFormatForRect.Alignment = StringAlignment.Near;
            strFormatForRect.LineAlignment = StringAlignment.Center;
            strFormatForRect.Trimming = StringTrimming.None;
        }

        public enum EnumSections
        {
            FirstSection = 0,
            SecondSection,
            ThirdSection
        }

        public override bool CheckIfTheObjectIsClicked(Point point)
        {
            if ((startPointRect1.X < point.X) && (point.X < startPointRect1.X + width) &&
                (startPointRect1.Y < point.Y) && (point.Y < startPointRect1.Y + rect1Height))
            {
                select = EnumSections.FirstSection;
                return true;
            }
            if ((startPointRect2.X < point.X) && (point.X < startPointRect2.X + width) &&
                (startPointRect2.Y < point.Y) && (point.Y < startPointRect2.Y + rect2Height))
            {
                select = EnumSections.SecondSection;
                return true;
            }
            if ((startPointRect3.X < point.X) && (point.X < startPointRect3.X + width) &&
               (startPointRect3.Y < point.Y) && (point.Y < startPointRect3.Y + rect3Height))
            {
                select = EnumSections.ThirdSection;
                return true;
            }
            return false;
        }

        public override void Move(int deltaX, int deltaY)
        {
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
        }

        public List<string> CheckSelectedList()
        {
            List<string> currentList = new List<string>();
            if (select == EnumSections.FirstSection)
            {
                currentList = listForRect1Text;
            }
            else if (select == EnumSections.SecondSection)
            {
                currentList = listForRect2Text;
            }
            else if (select == EnumSections.ThirdSection)
            {
                currentList = listForRect3Text;
            }
            return currentList;
        }

        public void CalculateClassCoordinates(List<string> rect1Text, List<string> rect2Text, List<string> rect3Text)
        {
            rect1Width = 0;
            rect2Width = 0;
            rect3Width = 0;
            Canvas canvas = Canvas.GetCanvas();
            SizeF textSize = new SizeF();
            foreach (string str in rect1Text)
            {
                textSize = canvas.graphics.MeasureString(str, canvas.font);
                if (textSize.Width > rect1Width)
                {
                    rect1Width = (int)textSize.Width;
                }
            }
            foreach (string str in rect2Text)
            {
                textSize = canvas.graphics.MeasureString(str, canvas.font);
                if (textSize.Width > rect2Width)
                {
                    rect2Width = (int)textSize.Width;
                }
            }
            foreach (string str in rect3Text)
            {
                textSize = canvas.graphics.MeasureString(str, canvas.font);
                if (textSize.Width > rect3Width)
                {
                    rect3Width = (int)textSize.Width;
                }
            }

            width = rect1Width > rect2Width ? rect1Width : rect2Width;
            width = width > rect3Width ? width : rect3Width;
            width += widthBuffer;

            //Rect1
            startPointRect1.X = StartPoint.X;
            startPointRect1.Y = StartPoint.Y;
            rect1Height = listForRect1Text.Count * (int)textSize.Height + heightYBuffer;
            //Rect2
            startPointRect2.X = StartPoint.X;
            startPointRect2.Y = startPointRect1.Y + rect1Height;
            rect2Height = listForRect2Text.Count * (int)textSize.Height + heightYBuffer;
            //Rect3
            startPointRect3.X = StartPoint.X;
            startPointRect3.Y = startPointRect2.Y + rect2Height;
            rect3Height = listForRect3Text.Count * (int)textSize.Height + heightYBuffer;

            height = rect1Height + rect2Height + rect3Height;
        }
    }
}
