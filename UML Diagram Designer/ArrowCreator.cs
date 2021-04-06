using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer
{
    public abstract class Arrow
    {
        private GraphicsPath _pathForCustomLineEndCap;
        private Pen _pen;
        protected CustomLineCap NotFilledArrow { get; private set; }
        protected CustomLineCap NotFilledDiamond { get; private set; }
        protected CustomLineCap FilledArrow { get; private set; }
        protected CustomLineCap FilledDiamond { get; private set; }

        

        public Arrow()
        {
            NotFilledArrow = CreateNotFilledArrowCap();
            NotFilledDiamond = CreateNotFilledDiamondCap();
            FilledArrow = CreateFilledArrowCap();
            FilledDiamond = CreateFilledDiamondCap();
        }

        private CustomLineCap CreateNotFilledArrowCap()
        {
            _pathForCustomLineEndCap = new GraphicsPath();

            _pathForCustomLineEndCap.AddLine(new Point(0, 0), new Point(-3, -3));
            _pathForCustomLineEndCap.AddLine(new Point(-3, -3), new Point(0, 0));
            _pathForCustomLineEndCap.AddLine(new Point(0, 0), new Point(3, -3));

            return new CustomLineCap(null, _pathForCustomLineEndCap);
        }

        private CustomLineCap CreateFilledArrowCap()
        {
            _pathForCustomLineEndCap = new GraphicsPath();

            _pathForCustomLineEndCap.AddLine(new Point(0, 0), new Point(0, 2));
            _pathForCustomLineEndCap.AddLine(new Point(0, 2), new Point(-3, -2));
            _pathForCustomLineEndCap.AddLine(new Point(-3, -2), new Point(3, -2));
            _pathForCustomLineEndCap.AddLine(new Point(3, -2), new Point(0, 2));

            return new CustomLineCap(_pathForCustomLineEndCap, null);
        }

        private CustomLineCap CreateNotFilledDiamondCap()
        {
            _pathForCustomLineEndCap = new GraphicsPath();

            _pathForCustomLineEndCap.AddLine(new Point(0, 0), new Point(2, 3));
            _pathForCustomLineEndCap.AddLine(new Point(2, 3), new Point(0, 6));
            _pathForCustomLineEndCap.AddLine(new Point(0, 6), new Point(-2, 3));
            _pathForCustomLineEndCap.AddLine(new Point(-2, 3), new Point(0, 0));

            return new CustomLineCap(null, _pathForCustomLineEndCap);
        }

        private CustomLineCap CreateFilledDiamondCap()
        {
            _pathForCustomLineEndCap = new GraphicsPath();

            _pathForCustomLineEndCap.AddLine(new Point(0, 0), new Point(-2, -3));
            _pathForCustomLineEndCap.AddLine(new Point(-2, -3), new Point(0, -6));
            _pathForCustomLineEndCap.AddLine(new Point(0, -6), new Point(2, -3));
            _pathForCustomLineEndCap.AddLine(new Point(2, -3), new Point(0, 0));

            return new CustomLineCap(_pathForCustomLineEndCap, null);
        }
    }
}
