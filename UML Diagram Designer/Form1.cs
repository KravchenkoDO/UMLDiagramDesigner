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
using UML_Diagram_Designer.Relationships;
using UML_Diagram_Designer.UMLClass;
using UML_Diagram_Designer.UMLClasses;

namespace UML_Diagram_Designer
{
    public partial class Form1 : Form
    {
        private Bitmap _mainBitmap;
        private Bitmap _tmpBitmap;
        private Graphics _graphics;
        private AbstractRelationship _currentRelationship;
        private AbstractUMLClass _currentClass;
        bool _isClickedLeftMouseButton = false;
        RelationshipType relationshipsType;
        UMLClassType umlClassType;
        DrawingType drawingType;

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
            relationshipsType = RelationshipType.Association;
            drawingType = DrawingType.Relationship;
        }

        private void inheritanceButton_Click(object sender, EventArgs e)
        {
            relationshipsType = RelationshipType.Inharitance;
            drawingType = DrawingType.Relationship;
        }

        private void realizationButton_Click(object sender, EventArgs e)
        {
            relationshipsType = RelationshipType.Realization;
            drawingType = DrawingType.Relationship;
        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            relationshipsType = RelationshipType.Aggregation;
            drawingType = DrawingType.Relationship;
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {
            relationshipsType = RelationshipType.Composition;
            drawingType = DrawingType.Relationship;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _isClickedLeftMouseButton = false;

            _graphics.Clear(Color.White);

            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (relationshipsType)
            {
                case RelationshipType.Aggregation:
                    _currentRelationship = new AggregationRelationship();
                    break;
                case RelationshipType.Association:
                    _currentRelationship = new AssociationRelationship();
                    break;
                case RelationshipType.Composition:
                    _currentRelationship = new CompositionRelationship();
                    break;
                case RelationshipType.Inharitance:
                    _currentRelationship = new InheritanceRelationship();
                    break;
                case RelationshipType.Realization:
                    _currentRelationship = new RealizationRelationship();
                    break;
            }
            switch (umlClassType)
            {
                case UMLClassType.OneSection:
                    _currentClass = new OneSectionUMLClass();
                    break;
                case UMLClassType.TwoSection:
                    _currentClass = new TwoSectionUMLClass();
                    break;
                case UMLClassType.ThreeSection:
                    _currentClass = new ThreeSectionUMLClass();
                    break;
                case UMLClassType.FourSection:
                    _currentClass = new FourSectionUMLClass();
                    break;
            }

            _isClickedLeftMouseButton = true;

            if (drawingType == DrawingType.Relationship)
            {
                _currentRelationship.StartPoint = e.Location;
            }

            if (drawingType == DrawingType.UmlClass)
            {
                _currentClass.StartPoint = e.Location;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isClickedLeftMouseButton == true)
            {
                if (drawingType == DrawingType.Relationship)
                {
                    _currentRelationship.Draw(_graphics);
                }

                if (drawingType == DrawingType.UmlClass)
                {
                    _currentClass.DrawUMLClass(_graphics, e.Location);
                }

                _mainBitmap = _tmpBitmap;
                _isClickedLeftMouseButton = false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isClickedLeftMouseButton == true)
            {
                _tmpBitmap = (Bitmap) _mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                if (drawingType == DrawingType.Relationship)
                {
                    _currentRelationship.EndPoint = e.Location;
                    _currentRelationship.Draw(_graphics);
                }

                if (drawingType == DrawingType.UmlClass)
                {
                    _currentClass.DrawUMLClass(_graphics, e.Location);
                }

                pictureBox1.Image = _tmpBitmap;
                //GC.Collect();
            }
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            umlClassType = UMLClassType.OneSection;
            drawingType = DrawingType.UmlClass;
        }
    }
}
