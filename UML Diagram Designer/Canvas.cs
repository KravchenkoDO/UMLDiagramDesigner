using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer
{
    public class Canvas
    {
        private static Canvas instance;
        public Bitmap _bitmap;
        public Graphics _graphics;
        public Pen _pen;
        public Brush _brush;
        public Color _penColor;
        public int _penSize;
        public Font _font;

        public static Canvas GetCanvas()
        {
            if (instance == null)
                instance = new Canvas();
            return instance;
        }
        public void SetCanvas(int width, int height)
        {
            _bitmap = new Bitmap(width, height);
            _graphics = Graphics.FromImage(_bitmap);
            _pen = new Pen(Color.Black, 3);
            _brush = new SolidBrush(Color.Black);
            _font = new Font("Times New Roman", emSize: 12f, FontStyle.Regular);
        }

        public void SetPenColor (Color penColor)
        {
            _penColor = penColor;
        }
        public void SetPenSize(int penSize)
        {
            _penSize = penSize;
        }

        public void SetBrush(Brush brush)
        {
            _brush = brush;
        }

        public void SetFont(Font font)
        {
            _font = font;
        }
    }
}
