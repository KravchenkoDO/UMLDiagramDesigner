using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UML_Diagram_Designer
{
    public class Canvas
    {
        private static Canvas instance;
        private float penWidth;
        private Color penColor;
        public PictureBox pictureBox;
        public Bitmap bitmap;
        public Graphics graphics;
        public Pen pen;
        public Brush brush;
        public Font font;
        public FontStyle fontRect1;
        public List<AbstractDiagramElement> listAbstractDiagramElements;

        public float PenSize
        {
            get
            {
                return penWidth;
            }
            set
            {
                penWidth = value;
                pen.Width = penWidth;
            }
        }

        public Color PenColor
        {
            get
            {
                return penColor;
            }
            set
            {
                penColor = value;
                pen.Color = penColor;
            }
        }

        public Font Font
        {
            get
            {
                return font;
            }
            set
            {
                font = value;

            }
        }

        public FontStyle FontStyle
        {
            get
            {
                return fontRect1;
            }
            set
            {
                fontRect1 = value;

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
            bitmap = new Bitmap(width, height);
            graphics = Graphics.FromImage(bitmap);
            fontRect1 = FontStyle.Italic;
            pen = new Pen(penColor, penWidth);
            brush = new SolidBrush(Color.Black);
            font = new Font("Times New Roman", 12);
        }

        public void SetPenParameters(Color color, float width)
        {
            PenColor = color;
            PenSize = width;
        }

        public void SetBrush(Brush brush)
        {
            this.brush = brush;
        }

        public void SetFont(Font font)
        {
            Font = font;
        }

        public Font SetFontStyle(FontStyle fontStyle)
        {
            FontStyle = fontStyle;
            return new Font(font, FontStyle);
        }

        public void RedrawElementsFromElementsList()
        {
            foreach (var element in listAbstractDiagramElements)
            {
                SetPenParameters(element.ObjectPenColor, element.ObjectPenWidth);
                element.Draw(instance);
            }
        }
    }
}