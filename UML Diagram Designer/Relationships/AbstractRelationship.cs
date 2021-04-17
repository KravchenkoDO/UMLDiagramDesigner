using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_Designer.Interfaces;

namespace UML_Diagram_Designer.Relationships
{
    public abstract class AbstractRelationship : AbstractDiagramElement
    {
        public CustomLineCap _cap;
        public DashStyle _lineStyle;
        private Point _movePoint;

        public override void Draw(Graphics graphics)
        {
            Pen _pen = new Pen(Color.Black, 5);
            _pen.CustomEndCap = _cap;
            _pen.DashStyle = _lineStyle;
            graphics.DrawLine(_pen, StartPoint, EndPoint);
        }

        public override bool CheckIfTheObjectIsClicked(Point point)
        {
            const int delta = 5;

            if (point.X < StartPoint.X + delta && point.X > StartPoint.X - delta &&
                point.Y < StartPoint.Y + delta && point.Y > StartPoint.Y - delta)
            {
                return true;
            }

            if (point.X < EndPoint.X + delta && point.X > EndPoint.X - delta &&
                point.Y < EndPoint.Y + delta && point.Y > EndPoint.Y - delta)
            {
                return true;
            }

            return false;
        }
        public Point CheckingTheStartOrEndOfAnArrow(bool CheckIfTheObjectIsClicked, Point point)
        {

            if (CheckIfTheObjectIsClicked == true)
            {
                if (point == StartPoint)
                {
                    _movePoint = StartPoint;
                }
                else
                    _movePoint = EndPoint;
            }

            return _movePoint;
        }

        public override void Move(int deltaX, int deltaY)
        {
            _movePoint= new Point(_movePoint.X + deltaX, _movePoint.Y + deltaY);
            //StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);

            //EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
        }
    }
}

