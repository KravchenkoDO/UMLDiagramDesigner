using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer
{
    public class Painter
    {
        private static Painter instance;
        public Bitmap _bitmap;
        public Graphics _graphics;
        public Pen _pen;
        public Color _penColor;
        public int _penSize;
        public Painter(int width, int height)
        {
            _bitmap = new Bitmap(width, height);
            _graphics = Graphics.FromImage(_bitmap);
            _pen = new Pen(Color.Black, 3);
        }
        public static Painter GetPainter( int width, int height)
        {
            if (instance == null)
                instance = new Painter(width, height);
            return instance;
        }

        public void ChangePenColor (Color penColor)
        {
            _penColor = penColor;
        }
        public void ChangePenSize(int penSize)
        {
            _penSize = penSize;
        }
    }
}
