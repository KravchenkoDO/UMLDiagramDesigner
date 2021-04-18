﻿using System;
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
        public Canvas(int width, int height)
        {
            _bitmap = new Bitmap(width, height);
            _graphics = Graphics.FromImage(_bitmap);
            _pen = new Pen(Color.Black, 3);
            _penColor = _pen.Color;
            _penSize = (int)_pen.Width;
            _brush = new SolidBrush(Color.Black);
            _font = new Font("Times New Roman", 12);
        }
        public static Canvas GetPainter( int width, int height)
        {
            if (instance == null)
                instance = new Canvas(width, height);
            return instance;
        }

        public void ChangePenColor (Color penColor)
        {
            PenColor = penColor;
        }
        public void ChangePenSize(int penSize)
        {
            PenSize = penSize;
        }

        public void ChangeBrush(Brush brush)
        {
            _brush = brush;
        }

        public void ChangeFont(Font font)
        {
            _font = font;
        }
    }
}