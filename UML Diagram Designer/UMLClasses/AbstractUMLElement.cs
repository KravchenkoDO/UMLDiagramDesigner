﻿using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace UML_Diagram_Designer.UMLClasses
{
    public abstract class AbstractUMLElement : AbstractDiagramElement
    {
        const int _widthBuffer = 5;
        const int _heightYBuffer = 5;
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

        public StringFormat strFormatForRect = new StringFormat();

        public StringBuilder sbForRect1Text = new StringBuilder(string.Empty);
        public StringBuilder sbForRect2Text = new StringBuilder(string.Empty);
        public StringBuilder sbForRect3Text = new StringBuilder(string.Empty);

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
            Rectangle rect3 = new Rectangle(_startPointRect3.X, _startPointRect3.Y, _width, _rect3Height);

            painter._graphics.DrawRectangle(painter._pen, rect1);
            painter._graphics.DrawRectangle(painter._pen, rect2);
            painter._graphics.DrawRectangle(painter._pen, rect3);
            painter._graphics.DrawString(sbForRect1Text.ToString(), painter._font, painter._brush, rect1, strFormatForRect);
            painter._graphics.DrawString(sbForRect2Text.ToString(), painter._font, painter._brush, rect2, strFormatForRect);
            painter._graphics.DrawString(sbForRect3Text.ToString(), painter._font, painter._brush, rect3, strFormatForRect);
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

        public List<string> CheckSelectedList()
        {
            List<string> currentList = new List<string>();
            if (select == EnumSections.FirstSection)
            {
                currentList = _listForRect1Text;
            }
            else if (select == EnumSections.SecondSection)
            {
                currentList = _listForRect2Text;
            }
            else if (select == EnumSections.ThirdSection)
            {
                currentList = _listForRect3Text;
            }
            return currentList;
        }

        public void CalculateClassCoordinates(List<string> rect1Text, List<string> rect2Text, List<string> rect3Text)
        {
            _rect1Width = 0;
            _rect2Width = 0;
            _rect3Width = 0;
            Canvas canvas = Canvas.GetCanvas();
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
