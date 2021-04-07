using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_Designer
{
    public partial class Form1 : Form
    {
        private Bitmap _mainBitmap;
        private Bitmap _tmpBitmap;
        private Graphics _graphics;
        private Pen _pen;
        private Arrow arrow;
        private Point _start;
        private Point _finish;
        bool _isClickedArrowButton = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            _pen = new Pen(Color.Black, 6);

            _graphics = Graphics.FromImage(_mainBitmap);
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = _mainBitmap;

            arrow = new Arrow(_graphics);
        }

        private void associationButton_Click(object sender, EventArgs e)
        {
            _isClickedArrowButton = true;

            _pen.CustomEndCap = arrow.NotFilledArrow;
            _pen.DashStyle = DashStyle.Solid;
        }

        private void inheritanceButton_Click(object sender, EventArgs e)
        {
            _isClickedArrowButton = true;

            _pen.CustomEndCap = arrow.FilledArrow;
            _pen.DashStyle = DashStyle.Solid;
        }

        private void realizationButton_Click(object sender, EventArgs e)
        {
            _isClickedArrowButton = true;

            _pen.CustomEndCap = arrow.FilledArrow;
            _pen.DashStyle = DashStyle.Dash;
        }

        private void dependencyButton_Click(object sender, EventArgs e)
        {
            _isClickedArrowButton = true;

            _pen.CustomEndCap = arrow.NotFilledArrow;
            _pen.DashStyle = DashStyle.Dash;
        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            _isClickedArrowButton = true;

            _pen.CustomEndCap = arrow.NotFilledDiamond;
            _pen.DashStyle = DashStyle.Solid;
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {
            _isClickedArrowButton = true;

            _pen.CustomEndCap = arrow.FilledDiamond;
            _pen.DashStyle = DashStyle.Solid;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _isClickedArrowButton = false;

            _graphics.Clear(Color.White);

            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _start = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _finish = e.Location;

            if (_isClickedArrowButton == true)
            {
                _graphics.DrawLine(_pen, _start, _finish);
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(_isClickedArrowButton == true)
            {

            }
        }
    }
}
