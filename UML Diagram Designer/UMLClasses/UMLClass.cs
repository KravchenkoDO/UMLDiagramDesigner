using System;
using System.Collections.Generic;
using System.Drawing;


namespace UML_Diagram_Designer.UMLClasses
{
    public class UMLClass : AbstractUMLClass
    {
        public Point _startPointRect2;
        public Point _startPointRect3;
        public float _rect1Height;
        public float _rect2Height;
        public float _rect3Height;
        public int _width = 80;
        const int _widthBuffer = 20;
        const int _heightYBuffer = 10;
        string text1;
        string text2;
        string text3;
        List<string> _listForRect1Text;
        List<string> _listForRect2Text;
        List<string> _listForRect3Text;
        Canvas canvas = Canvas.GetCanvas();


        public UMLClass(Color lineColor, float lineWidth)
        {
            _listForRect1Text = new List<string>(); //{ "" };
            _listForRect2Text = new List<string>(); //{ "", "" };
            _listForRect3Text = new List<string>(); //{ "", "", "" };
            ObjectPenColor = lineColor;
            ObjectPenWidth = lineWidth;
        }
        
        public float GetCoordinatesForRect1()
        {
            _rect1Height = 1 * 10;// _listForRect1Text.Count * canvas._font.SizeInPoints * canvas._graphics.DpiX / 72 + _heightYBuffer;
            return _rect1Height;
        }
        public Point GetCoordinatesForRect2(Point StartPoint)
        {
            _startPointRect2.X = StartPoint.X;
            _startPointRect2.Y = StartPoint.Y + (int)_rect1Height;
            _rect2Height = 2 * 10;//_listForRect2Text.Count * canvas._font.SizeInPoints * canvas._graphics.DpiX / 72 + _heightYBuffer; ;
            return _startPointRect2;
        }
        public Point GetCoordinatesForRect3(Point StartPoint)
        {
            _startPointRect3.X = StartPoint.X;
            _startPointRect3.Y = StartPoint.Y + (int)_rect2Height;
            _rect3Height = 5 * 10;//_listForRect3Text.Count * canvas._font.SizeInPoints * canvas._graphics.DpiX / 72 + _heightYBuffer; ;
            return _startPointRect3;
        }
        public override void Draw(Canvas painter)
        {
            StringFormat strFormat1 = new StringFormat();
            text1 = string.Empty;
            text2 = string.Empty;
            text3 = string.Empty;
            strFormat1.Alignment = StringAlignment.Near;
            strFormat1.LineAlignment = StringAlignment.Near;
            strFormat1.Trimming = StringTrimming.Character;

            foreach (var text in _listForRect1Text)
            {
                text1 += text + "\n";
            }
            foreach (var text in _listForRect2Text)
            {
                text2 += text + "\n";
            }
            foreach (var text in _listForRect3Text)
            {
                text3 += text + "\n";
            }
            Rectangle rect1 = new Rectangle(StartPoint.X, StartPoint.Y, _width, (int)GetCoordinatesForRect1());
            Rectangle rect2 = new Rectangle(StartPoint.X, GetCoordinatesForRect2(StartPoint).Y, _width, (int)_rect2Height);//* _rect2Text.Count / 10
            Rectangle rect3 = new Rectangle(StartPoint.X, GetCoordinatesForRect3(GetCoordinatesForRect2(StartPoint)).Y, _width, (int)_rect3Height );//* _rect3Text.Count / 10

            painter._graphics.DrawRectangle(painter._pen, rect1);
            painter._graphics.DrawRectangle(painter._pen, rect2);
            painter._graphics.DrawRectangle(painter._pen, rect3);

            painter._graphics.DrawString(text1, painter._font, new SolidBrush(Color.Red), rect1, strFormat1);
            painter._graphics.DrawString(text2, painter._font, new SolidBrush(Color.Red), rect2, strFormat1);
            painter._graphics.DrawString(text3, painter._font, new SolidBrush(Color.Red), rect3, strFormat1);

        }
        public override void Move(int deltaX, int deltaY)
        {
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
        }
        public override bool CheckIfTheObjectIsClicked(Point point)
        {
            _rect1Height = GetCoordinatesForRect1();
            if ((StartPoint.X < point.X) && (point.X < StartPoint.X + _width) &&
                (StartPoint.Y < point.Y) && (point.Y < StartPoint.Y + _rect1Height))
            {
                select = EnumSections.FirstSection;
                return true;
            }
            if ((GetCoordinatesForRect2(StartPoint).X < point.X) && (point.X < GetCoordinatesForRect2(StartPoint).X + _width) &&
                (GetCoordinatesForRect2(StartPoint).Y < point.Y) && (point.Y < GetCoordinatesForRect2(StartPoint).Y + _rect2Height))
            {
                select = EnumSections.SecondSection;
                return true;
            }
            if ((GetCoordinatesForRect3(StartPoint).X < point.X) && (point.X < GetCoordinatesForRect3(StartPoint).X + _width) &&
               (GetCoordinatesForRect3(StartPoint).Y < point.Y) && (GetCoordinatesForRect3(StartPoint).Y < StartPoint.Y + _rect3Height))
            {
                select = EnumSections.ThirdSection;
                return true;
            }
                return false;
        }
        public override void SaveElementText(string strText)
        {
            if (select == EnumSections.FirstSection)
            {
                _listForRect1Text.Add(strText);
            }
            else if (select == EnumSections.SecondSection)
            {
                _listForRect2Text.Add(strText);
            }
            else if (select == EnumSections.ThirdSection)
            {
                _listForRect3Text.Add(strText);
            }
        }
    }
}
