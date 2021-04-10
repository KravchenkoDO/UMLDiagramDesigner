using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UML_Diagram_Designer.Relationships;
using UML_Diagram_Designer.UMLClasses;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace UML_Diagram_Designer
{
    public partial class Form1 : Form
    {
        private Bitmap _mainBitmap;
        private Graphics _graphics;
        private AbstractRelationship _currentRelationship;
        bool _isMouseMove = false;
        RelationshipType relationshipsType;
        DrawingType drawingType;
        private UMLClass _UMLClass = new UMLClass();
        List<AbstractRelationship> listRelationships = new List<AbstractRelationship>();
        List<UMLClass> listUMLClasses = new List<UMLClass>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = _mainBitmap;
            _graphics = Graphics.FromImage(_mainBitmap);
        }
        private void associationButton_Click(object sender, EventArgs e)
        {
            relationshipsType = RelationshipType.Association;
            actionType = ActionType.DrawRelationship;
        }

        private void inheritanceButton_Click(object sender, EventArgs e)
        {
            relationshipsType = RelationshipType.Inharitance;
            actionType = ActionType.DrawRelationship;
        }

        private void realizationButton_Click(object sender, EventArgs e)
        {
            relationshipsType = RelationshipType.Realization;
            actionType = ActionType.DrawRelationship;
        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            relationshipsType = RelationshipType.Aggregation;
            actionType = ActionType.DrawRelationship;
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {
            relationshipsType = RelationshipType.Composition;
            actionType = ActionType.DrawRelationship;
        }
        private void classButton_Click(object sender, EventArgs e)
        {
            drawingType = DrawingType.UmlClass;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _isMouseMove = false;
            _graphics.Clear(Color.White);
            listUMLClasses.Clear();
            listRelationships.Clear();
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
            _isMouseMove = true;
            if (drawingType == DrawingType.Relationship)
            {
                _currentRelationship.StartPoint = e.Location;
            }
            if (drawingType == DrawingType.UmlClass)
            {
                _UMLClass.StartPoint = e.Location;
            }

        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseMove)
            {
                if (drawingType == DrawingType.Relationship)
                {
                    _currentRelationship.EndPoint = e.Location;
                }
                if (drawingType == DrawingType.UmlClass)
                {
                    _UMLClass.EndPoint = e.Location;
                }
                pictureBox1.Invalidate();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isMouseMove)
            {
                if (actionType == ActionType.DrawRelationship)
                {
                    listRelationships.Add(_currentRelationship);
                }

                if (actionType == ActionType.DrawUmlClass)
                {
                    listUMLClasses.Add(_UMLClass);
                }
                _isMouseMove = false;
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (_isMouseMove)
            {
                _graphics.Clear(pictureBox1.BackColor);
                if (drawingType == DrawingType.Relationship)
                {
                    _currentRelationship.Draw(_graphics);
                foreach (var relation in listRelationships)
                {
                    relation.Draw(_graphics);
                }
                }
                if (drawingType == DrawingType.UmlClass)
                {
                    _UMLClass.DrawUMLClass(_graphics);
                foreach (var umlClass in listUMLClasses)
                {
                    umlClass.DrawUMLClass(_graphics);
                }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            
        }
    }
}
