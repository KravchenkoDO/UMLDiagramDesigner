using System;
using System.Collections.Generic;
using System.Drawing;


namespace UML_Diagram_Designer.UMLClasses
{
    public class UMLClass : AbstractDiagramElement
    {
        public Point _startPointRect2;
        public Point _startPointRect3;
        public int _rect1Height;
        public int _rect2Height;
        public int _rect3Height;
        private Canvas canvas;
        public int _width=80;
        const int _widthBuffer = 20;
        const int _heightYBuffer = 20;
        List<string> _listForRect1Text = new List<string>();
        List<string> _listForRect2Text = new List<string>();
        List<string> _listForRect3Text = new List<string>();
        EnumSections select;

        
        
        public int GetCoordinatesForRect1()
        {
            _rect1Height = 1 * 10;//(int)(_listForRect1Text.Count * canvas._font.Size);
            return _rect1Height;
        }
        public Point GetCoordinatesForRect2(Point StartPoint)
        {
            _startPointRect2.X = StartPoint.X;
            _startPointRect2.Y = StartPoint.Y + _rect1Height;;
            _rect2Height = 2 * 10 + _heightYBuffer;//(int)(_rect2Text.Count * canvas._font.Size);
            return _startPointRect2;

        }

        public Point GetCoordinatesForRect3(Point StartPoint)
        {
            _startPointRect3.X = StartPoint.X;
            _startPointRect3.Y = StartPoint.Y + _rect2Height;// _rect2Text.Count;
            _rect3Height = 5 * 10 + _heightYBuffer;// (int)(_rect3Text.Count * canvas._font.Size);
            return _startPointRect3;
        }

        public override void Draw(Canvas painter)
        {
            //// Construct string format and alignment
            //StringFormat strFormat1 = new StringFormat();
            //// Set alignment, line alignment, and trimming
            //// properties of string format
            //strFormat1.Alignment = StringAlignment.Near;
            //strFormat1.LineAlignment = StringAlignment.Near;
            //strFormat1.Trimming = StringTrimming.Character;
            //// Draw GDI+ objects
            //painter._graphics.DrawRectangle(painter._pen, rect1);
            //painter._graphics.DrawRectangle(painter._pen, rect2);
            //painter._graphics.DrawRectangle(painter._pen, rect3);
            //painter._graphics.DrawString(text, arialFont,
            //new SolidBrush(Color.Red), rect2, strFormat1);
            // Dispose of objects
            //arialFont.Dispose();
            //arialFont.Dispose();
            //verdanaFont.Dispose();
            //arialFamily.Dispose();

            //_width = Math.Abs((int)(painter._bitmap.Width * _deltaX));
            //_height = Math.Abs((int)(painter._bitmap.Height * _deltaY));

            Rectangle rect1 = new Rectangle(StartPoint.X, StartPoint.Y, _width, GetCoordinatesForRect1());
            Rectangle rect2 = new Rectangle(StartPoint.X, GetCoordinatesForRect2(StartPoint).Y, _width, _rect2Height);//* _rect2Text.Count / 10
            Rectangle rect3 = new Rectangle(StartPoint.X, GetCoordinatesForRect3(GetCoordinatesForRect2(StartPoint)).Y, _width, _rect3Height );//* _rect3Text.Count / 10

            painter._graphics.DrawRectangle(painter._pen, rect1);
            painter._graphics.DrawRectangle(painter._pen, rect2);
            painter._graphics.DrawRectangle(painter._pen, rect3);
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
