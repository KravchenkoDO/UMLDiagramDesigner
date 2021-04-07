using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.Arrows
{
    public class CompositionArrow : AbstractArrow
    {
        public CompositionArrow()
        {
            _pen = new Pen(Color.Black, 6);
            _pen.CustomEndCap = CreateFilledDiamondCap();
            _pen.DashStyle = DashStyle.Solid;
        }

        private CustomLineCap CreateFilledDiamondCap()
        {
            _pathForCustomLineEndCap = new GraphicsPath();

            _pathForCustomLineEndCap.AddLine(new PointF(0.0f, 0.0f), new PointF(-2, -3));
            _pathForCustomLineEndCap.AddLine(new PointF(-2, -3), new PointF(0, -6));
            _pathForCustomLineEndCap.AddLine(new PointF(0, -6), new PointF(2, -3));
            _pathForCustomLineEndCap.AddLine(new PointF(2, -3), new PointF(0.0f, 0.0f));

            return new CustomLineCap(_pathForCustomLineEndCap, null);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(_pen, GetPoints().ToArray());
        }
    }
}
