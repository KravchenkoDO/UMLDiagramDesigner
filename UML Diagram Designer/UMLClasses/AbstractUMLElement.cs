
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace UML_Diagram_Designer.UMLClasses
{
    public abstract class AbstractUMLElement : AbstractDiagramElement
    {
        const int _widthBuffer = 2;
        const int _heightYBuffer = 2;
        public int _width = 80;
        public int _height = 80;
        public DashStyle _lineStyle;

        public Point _startPointRect1;
        public Point _startPointRect2;
        public Point _startPointRect3;

        public int _rect1Height;
        public int _rect2Height;
        public int _rect3Height;
        public int _rect1Width;
        public int _rect2Width;
        public int _rect3Width;

        public List<string> _listForRect1Text;
        public List<string> _listForRect2Text;
        public List<string> _listForRect3Text;

        public StringFormat strFormatRect1 = new StringFormat();
        public StringFormat strFormatRect23 = new StringFormat();

        public StringBuilder sbForRect1Text = new StringBuilder(string.Empty);
        public StringBuilder sbForRect2Text = new StringBuilder(string.Empty);
        public StringBuilder sbForRect3Text = new StringBuilder(string.Empty);

        public Canvas canvas = Canvas.GetCanvas();

        public EnumSections select;
        public AbstractUMLElement()
        {
            strFormatRect1.Alignment = StringAlignment.Center;
            strFormatRect1.LineAlignment = StringAlignment.Center;
            strFormatRect1.Trimming = StringTrimming.None;
            strFormatRect23.Alignment = StringAlignment.Near;
            strFormatRect23.LineAlignment = StringAlignment.Center;
            strFormatRect23.Trimming = StringTrimming.None;
        }
        public enum EnumSections
        {
            FirstSection = 0,
            SecondSection,
            ThirdSection
        }
        public override bool CheckIfTheObjectIsClicked(Point point)
        {
            if ((_startPointRect1.X < point.X) && (point.X < _startPointRect1.X + _width) &&
                (_startPointRect1.Y < point.Y) && (point.Y < _startPointRect1.Y + _rect1Height))
            {
                select = EnumSections.FirstSection;
                return true;
            }
            if ((_startPointRect2.X < point.X) && (point.X < _startPointRect2.X + _width) &&
                (_startPointRect2.Y < point.Y) && (point.Y < _startPointRect2.Y + _rect2Height))
            {
                select = EnumSections.SecondSection;
                return true;
            }
            if ((_startPointRect3.X < point.X) && (point.X < _startPointRect3.X + _width) &&
               (_startPointRect3.Y < point.Y) && (point.Y < _startPointRect3.Y + _rect3Height))
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
        public override List<string> SaveElementText(string strText)
        {
            List<string> currentList = new List<string>();
            if (select == EnumSections.FirstSection)
            {
                _listForRect1Text.Add(strText);
                currentList = _listForRect1Text;
            }
            else if (select == EnumSections.SecondSection)
            {
                _listForRect2Text.Add(strText);
                currentList = _listForRect2Text;
            }
            else if (select == EnumSections.ThirdSection)
            {
                _listForRect3Text.Add(strText);
                currentList = _listForRect3Text;
            }
            return currentList;
        }
        public void CalculateClassCoordinates(List<string> rect1Text, List<string> rect2Text, List<string> rect3Text)
        {
            SizeF textSize = new SizeF();
            foreach (string str in rect1Text)
            {
                textSize = canvas._graphics.MeasureString(str, canvas._font);
                if (textSize.Width > _rect1Width)
                {
                    _rect1Width = (int)textSize.Width;
                }
            }
            foreach (string str in rect2Text)
            {
                textSize = canvas._graphics.MeasureString(str, canvas._font);
                if (textSize.Width > _rect2Width)
                {
                    _rect2Width = (int)textSize.Width;
                }
            }
            foreach (string str in rect3Text)
            {
                textSize = canvas._graphics.MeasureString(str, canvas._font);
                if (textSize.Width > _rect3Width)
                {
                    _rect3Width = (int)textSize.Width;
                }
            }
            _width = _rect1Width > _rect2Width ? _rect1Width : _rect2Width;
            _width = _width > _rect3Width ? _width : _rect3Width;
            _width += _widthBuffer;

            //Rect1
            _startPointRect1.X = StartPoint.X;
            _startPointRect1.Y = StartPoint.Y;
            _rect1Height = _listForRect1Text.Count * (int)textSize.Height + _heightYBuffer;
            //Rect2
            _startPointRect2.X = StartPoint.X;
            _startPointRect2.Y = _startPointRect1.Y + _rect1Height;
            _rect2Height = _listForRect2Text.Count * (int)textSize.Height + _heightYBuffer;
            //Rect3
            _startPointRect3.X = StartPoint.X;
            _startPointRect3.Y = _startPointRect2.Y + _rect2Height;
            _rect3Height = _listForRect3Text.Count * (int)textSize.Height + _heightYBuffer;

            _height = _rect1Height + _rect2Height + _rect3Height;
        }
    }
}
