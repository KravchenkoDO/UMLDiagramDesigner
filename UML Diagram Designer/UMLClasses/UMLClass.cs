using System;
using System.Collections.Generic;
using System.Drawing;


namespace UML_Diagram_Designer.UMLClasses
{
    public class UMLClass : AbstractDiagramElement
    {
        public int _width;
        public int _height;
        const double _deltaX = 0.2;
        const double _deltaY = 0.3;
        List<string> _rect1Text = new List<string>();
        List<string> _rect2Text = new List<string>();
        List<string> _rect3Text = new List<string>();
        public enum SelectedSection
        {
            FirstSection = 0,
            SecondSection,
            ThirdSection
        }
        public override void Draw(Canvas painter)
        {
            //// Create a Graphics object
            //string text = "Yeah!!!We are drawing string text in the rectangle!";
            //// Create font families
            //FontFamily arialFamily = new FontFamily("Times New Roman");
            //// Construct Font objects
            //Font verdanaFont =
            //new Font("Verdana", 10, FontStyle.Bold);
            //Font arialFont = new Font(arialFamily, 12);
            // Create rectangles
            //_width = Math.Abs((int)(painter._bitmap.Width * _deltaX));
            //_height = Math.Abs((int)(painter._bitmap.Height * _deltaY));
            //Rectangle rect1 = new Rectangle(StartPoint.X, StartPoint.Y, _width, (int)(_height * 0.2));
            //Rectangle rect2 = new Rectangle(StartPoint.X, StartPoint.Y + (int)(_height * 0.2), _width, (int)(_height * 0.4));
            //Rectangle rect3 = new Rectangle(StartPoint.X, StartPoint.Y + (int)(_height * 0.6), _width, (int)(_height * 0.4));
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

            _width = Math.Abs((int)(painter._bitmap.Width * _deltaX));
            _height = Math.Abs((int)(painter._bitmap.Height * _deltaY));

            _rect1Text.Add("Name");
            _rect2Text.Add("Bla-Bla");
            _rect2Text.Add("Bla-Bla-Bla");
            _rect3Text.Add("Bla-Bla-Bla");
            _rect3Text.Add("Bla-Bla-Bla");
            _rect3Text.Add("Bla-Bla-Bla");

            Rectangle rect1 = new Rectangle(StartPoint.X, StartPoint.Y, _width, (int)(_height * 0.2));
            Rectangle rect2 = new Rectangle(StartPoint.X, StartPoint.Y + (int)(_height * 0.2), _width, (int)(_height * 0.4 ));//* _rect2Text.Count / 10
            Rectangle rect3 = new Rectangle(StartPoint.X, StartPoint.Y + (int)(_height * 0.6), _width, (int)(_height * 0.4 ));//* _rect3Text.Count / 10

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
            int xMax;
            int xMin;
            int yMax;
            int yMin;

            if (StartPoint.X > StartPoint.X + _width)
            {
                xMax = StartPoint.X;
                xMin = StartPoint.X + _width;
            }
            else
            {
                xMin = StartPoint.X;
                xMax = StartPoint.X + _width;
            }

            if (StartPoint.Y > StartPoint.Y + _height)
            {
                yMax = StartPoint.Y;
                yMin = StartPoint.Y + _height;
            }
            else
            {
                yMin = StartPoint.Y;
                yMax = StartPoint.Y + _height;
            }

            if (point.X <= xMax && point.X >= xMin
               && point.Y <= yMax && point.Y >= yMin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
    //{
    //    public Pen _pen = new Pen(Color.Black, 5);
    //    public Point StartPoint { set; get; }
    //    public Point EndPoint { set; get; }
    //    public int Width { set; get; }
    //    public int Height { set; get; }

    //    public UMLClass(Color color, int width)
    //    {
    //        _pen = new Pen(color, width);
    //    }

    //    public void DrawUMLClass(Graphics graphics) //int koef = 1, int classCount = 2)
    //    {
    //        Width = Math.Abs(EndPoint.X - StartPoint.X);
    //        Height = Math.Abs(EndPoint.Y - StartPoint.Y);

    //        graphics.DrawRectangle(_pen, StartPoint.X, StartPoint.Y, Width, Height);// * koef, _height * koef);
    //        graphics.DrawRectangle(_pen, StartPoint.X, StartPoint.Y, Width, Height / 4);
    //    }

    //    public override bool CheckIfTheObjectIsClicked(Point point)
    //    {
    //        int xMax;
    //        int xMin;
    //        int yMax;
    //        int yMin;

    //        if (StartPoint.X > EndPoint.X)
    //        {
    //            xMax = StartPoint.X;
    //            xMin = EndPoint.X;
    //        }
    //        else
    //        {
    //            xMin = StartPoint.X;
    //            xMax = EndPoint.X;
    //        }

    //        if (StartPoint.Y > EndPoint.Y)
    //        {
    //            yMax = StartPoint.Y;
    //            yMin = EndPoint.Y;
    //        }
    //        else
    //        {
    //            yMin = StartPoint.Y;
    //            yMax = EndPoint.Y;
    //        }

    //        if (point.X <= xMax && point.X >= xMin
    //           && point.Y <= yMax && point.Y >= yMin)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }

    //    public override void Move(int deltaX, int deltaY)
    //    {
    //        StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
    //        EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
    //    }
    //}
}
