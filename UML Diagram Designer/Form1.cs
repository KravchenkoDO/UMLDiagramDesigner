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
        private Bitmap _bitmap;
        private Graphics _graphics;
        private Pen _pen;
        private Point _start;
        private Point _finish;
        GraphicsPath pathForCustomLineEndCap;
        CustomLineCap _notFilledArrow;
        CustomLineCap _notFilledDiamond;
        CustomLineCap _filledArrow;
        CustomLineCap _filledDiamond;
        bool _isClickedArrowButton = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _pen = new Pen(Color.Black, 6);
            _graphics = Graphics.FromImage(_bitmap);
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = _bitmap;

            CreateNotFilledArrowCap();
            CreateFilledArrowCap();
            CreateNotFilledDiamondCap();
            CreateFilledDiamondCap();
        }

        private void CreateNotFilledArrowCap()
        {
            pathForCustomLineEndCap = new GraphicsPath();

            pathForCustomLineEndCap.AddLine(new Point(0, 0), new Point(-3, -3));
            pathForCustomLineEndCap.AddLine(new Point(-3, -3), new Point(0, 0));
            pathForCustomLineEndCap.AddLine(new Point(0, 0), new Point(3, -3));

            CustomLineCap NotFilledArrowCap = new CustomLineCap(null, pathForCustomLineEndCap);
            NotFilledArrowCap.SetStrokeCaps(LineCap.Round, LineCap.Round);

            _notFilledArrow = NotFilledArrowCap;
        }

        private void CreateFilledArrowCap()
        {
            pathForCustomLineEndCap = new GraphicsPath();

            pathForCustomLineEndCap.AddLine(new Point(0, 0), new Point(0, 2));
            pathForCustomLineEndCap.AddLine(new Point(0, 2), new Point(-3, -2));
            pathForCustomLineEndCap.AddLine(new Point(-3, -2), new Point(3, -2));
            pathForCustomLineEndCap.AddLine(new Point(3, -2), new Point(0, 2));

            CustomLineCap FilledArrowCap = new CustomLineCap(pathForCustomLineEndCap, null);
            FilledArrowCap.SetStrokeCaps(LineCap.Round, LineCap.Round);

            _filledArrow = FilledArrowCap;
        }

        private void CreateNotFilledDiamondCap()
        {
            pathForCustomLineEndCap = new GraphicsPath();

            pathForCustomLineEndCap.AddLine(new Point(0, 0), new Point(2, 3));
            pathForCustomLineEndCap.AddLine(new Point(2, 3), new Point(0, 6));
            pathForCustomLineEndCap.AddLine(new Point(0, 6), new Point(-2, 3));
            pathForCustomLineEndCap.AddLine(new Point(-2, 3), new Point(0, 0));


            CustomLineCap NotFilledDiamondCap = new CustomLineCap(null, pathForCustomLineEndCap);
            NotFilledDiamondCap.SetStrokeCaps(LineCap.Round, LineCap.Round);

            _notFilledDiamond = NotFilledDiamondCap;
        }

        private void CreateFilledDiamondCap()
        {
            pathForCustomLineEndCap = new GraphicsPath();

            pathForCustomLineEndCap.AddLine(new Point(0, 0), new Point(-2, -3));
            pathForCustomLineEndCap.AddLine(new Point(-2, -3), new Point(0, -6));
            pathForCustomLineEndCap.AddLine(new Point(0, -6), new Point(2, -3));
            pathForCustomLineEndCap.AddLine(new Point(2, -3), new Point(0, 0));

            CustomLineCap FilledDiamondCap = new CustomLineCap(pathForCustomLineEndCap, null);
            FilledDiamondCap.SetStrokeCaps(LineCap.Round, LineCap.Round);

            _filledDiamond = FilledDiamondCap;
        }

        private void associationButton_Click(object sender, EventArgs e)
        {
            _isClickedArrowButton = true;
            _pen.StartCap = LineCap.Flat;
            _pen.CustomEndCap = _notFilledArrow;
            _pen.DashStyle = DashStyle.Solid;
        }

        private void inheritanceButton_Click(object sender, EventArgs e)
        {
            _isClickedArrowButton = true;
            _pen.StartCap = LineCap.Flat;
            _pen.CustomEndCap = _filledArrow;
            _pen.DashStyle = DashStyle.Solid;
        }

        private void realizationButton_Click(object sender, EventArgs e)
        {
            _isClickedArrowButton = true;
            _pen.StartCap = LineCap.Flat;
            _pen.CustomEndCap = _filledArrow;
            _pen.DashStyle = DashStyle.Dash;
        }

        private void dependencyButton_Click(object sender, EventArgs e)
        {
            _isClickedArrowButton = true;
            _pen.StartCap = LineCap.Flat;
            _pen.CustomEndCap = _notFilledArrow;
            _pen.DashStyle = DashStyle.Dash;
        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            _isClickedArrowButton = true;
            _pen.StartCap = LineCap.Flat;
            _pen.CustomEndCap = _notFilledDiamond;
            _pen.DashStyle = DashStyle.Solid;
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {
            _isClickedArrowButton = true;
            _pen.StartCap = LineCap.Flat;
            _pen.CustomEndCap = _filledDiamond;
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

        
    }
}
