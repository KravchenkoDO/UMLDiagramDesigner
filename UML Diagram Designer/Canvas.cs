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
        public Font _font;
        public List<AbstractDiagramElement> listAbstractDiagramElements;
        private float _penSize;
        private Color _penColor;
        public float PenSize
        {
            get
            {
                return _penSize;
            }
            set
            {
                _penSize = value;
                _pen.Width = _penSize;
            }
        }
        public Color PenColor
        {
            get
            {
                return _penColor;
            }
            set
            {
                _penColor = value;
                _pen.Color = _penColor;
            }
        }
        
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
            _penColor = _pen.Color;
            _penSize = _pen.Width;
            _brush = new SolidBrush(Color.Black);
            _font = new Font("Times New Roman", 12);
        }

        public void SetPenParameters(Color color, float width)
        {
            PenColor = color;
            PenSize = width;
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