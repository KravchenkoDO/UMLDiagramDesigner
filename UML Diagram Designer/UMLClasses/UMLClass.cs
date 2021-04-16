using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_Designer.Interfaces;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UML_Diagram_Designer.UMLClasses
{
    public class UMLClass : AbstractDiagramElement
    {
        //public Point StartPoint { set; get; }
        //public Point EndPoint { set; get; }
        public int _width;
        public int _height;
        const double _deltaX=0.2;
        const double _deltaY=0.5;
        public override bool CheckIfTheObjectIsClicked(Point point)
        {
            throw new NotImplementedException();
        }

        public override void Draw(Painter painter)
        {

             
            _width = Math.Abs(StartPoint.X + (int)(painter._bitmap.Width /15));
            _height = Math.Abs(StartPoint.Y + (int)(painter._bitmap.Height /10));

            painter._graphics.DrawRectangle(painter._pen, StartPoint.X, StartPoint.Y, _width, _height);// * koef, _height * koef);
            painter._graphics.DrawRectangle(painter._pen, StartPoint.X, StartPoint.Y, _width, _height / 4);
        }

        public override void Move(int deltaX, int deltaY)
        {
            throw new NotImplementedException();
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
