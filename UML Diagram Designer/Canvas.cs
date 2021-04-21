using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_Designer
{
    public class Canvas
    {
        private static Canvas instance;
        public PictureBox _pictureBox;
        public Bitmap _bitmap;
        public Graphics _graphics;
        public Pen _pen;
        public Brush _brush;
        public Font _font;
        public List<AbstractDiagramElement> _listAbstractDiagramElements;
        private float _penWidth;
        private Color _penColor;
        public float PenSize
        {
            get
            {
                return _penWidth;
            }
            set
            {
                _penWidth = value;
                _pen.Width = _penWidth;
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

        public Font Font
        {
            get
            {
                return _font;
            }
            set
            {
                _font = value;
                
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
            _pen = new Pen(_penColor, _penWidth);
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
            Font = font;
        }

        public void RedrawElementsFromElementsList()
        {
            foreach (var element in _listAbstractDiagramElements)
            {
                SetPenParameters(element.ObjectPenColor, element.ObjectPenWidth);
                element.Draw(instance);
            }
        }
    }
}