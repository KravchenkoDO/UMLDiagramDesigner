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
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

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
                _movePoint = StartPoint;
            }

            if (point.X < EndPoint.X + delta && point.X > EndPoint.X - delta &&
                point.Y < EndPoint.Y + delta && point.Y > EndPoint.Y - delta)
            {
                return true;
                _movePoint = EndPoint;
            }

                return false;
        }

        public override void Move(int deltaX, int deltaY)
        {
            if (_movePoint == StartPoint)
            {
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
            }
            if (_movePoint == EndPoint)
            {
            EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
            }
        }
    }
}
