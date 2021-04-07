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
using UML_Diagram_Designer.Arrows;

namespace UML_Diagram_Designer
{
    public partial class Form1 : Form
    {
        private Bitmap _mainBitmap;
        private Bitmap _tmpBitmap;
        private Graphics _graphics;
        private AbstractArrow _currentArrow;
        bool _isClickedLeftMouseButton = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = _mainBitmap;
        }

        private void associationButton_Click(object sender, EventArgs e)
        {
            _currentArrow = new AssociationArrow();
        }

        private void inheritanceButton_Click(object sender, EventArgs e)
        {
            _currentArrow = new InheritanceArrow();
        }

        private void realizationButton_Click(object sender, EventArgs e)
        {
            _currentArrow = new RealizationArrow();
        }

        private void dependencyButton_Click(object sender, EventArgs e)
        {
            _currentArrow = new DependencyArrow();
        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            _currentArrow = new AggregationArrow();
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {
            _currentArrow = new CompositionArrow();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _isClickedLeftMouseButton = false;

            _graphics.Clear(Color.White);

            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _isClickedLeftMouseButton = true;
            _currentArrow.StartPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isClickedLeftMouseButton == true)
            {
                _isClickedLeftMouseButton = false;
                _currentArrow.Draw(_graphics);
                _mainBitmap = _tmpBitmap;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(_isClickedLeftMouseButton == true)
            {
                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                _currentArrow.EndPoint = e.Location;

                _currentArrow.Draw(_graphics);

                pictureBox1.Image = _tmpBitmap;
                GC.Collect();
            }
        }

        private void classButton_Click(object sender, EventArgs e)
        {

        }
    }
}
