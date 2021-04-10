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
        bool _isClickedMoveButton = false;
        RelationshipType _relationshipsType;
        ActionType _actionType;
        private UMLClass _UMLClass;
        List<AbstractRelationship> _listRelationships;
        List<UMLClass> _listUMLClasses;
        Point _pointForMove;

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
            _listRelationships = new List<AbstractRelationship>();
            _listUMLClasses = new List<UMLClass>();
        }
        private void associationButton_Click(object sender, EventArgs e)
        {
            _relationshipsType = RelationshipType.Association;
            _actionType = ActionType.DrawRelationship;
        }

        private void inheritanceButton_Click(object sender, EventArgs e)
        {
            _relationshipsType = RelationshipType.Inharitance;
            _actionType = ActionType.DrawRelationship;
        }

        private void realizationButton_Click(object sender, EventArgs e)
        {
            _relationshipsType = RelationshipType.Realization;
            _actionType = ActionType.DrawRelationship;
        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            _relationshipsType = RelationshipType.Aggregation;
            _actionType = ActionType.DrawRelationship;
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {
            _relationshipsType = RelationshipType.Composition;
            _actionType = ActionType.DrawRelationship;
        }
        private void classButton_Click(object sender, EventArgs e)
        {
            _actionType = ActionType.DrawUmlClass;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _isMouseMove = false;
            _graphics.Clear(Color.White);
            _listUMLClasses.Clear();
            _listRelationships.Clear();
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_isClickedMoveButton)
                {
                    foreach (AbstractRelationship a in _listRelationships)
                    {
                        if (a.IsItYou(e.Location))
                        {
                            _currentRelationship = a;
                            break;
                        }
                    }

                    if (_currentRelationship != null)
                    {
                        _listRelationships.Remove(_currentRelationship);

                        foreach (AbstractRelationship a in _listRelationships)
                        {
                            a.Draw(_graphics);
                        }

                        _pointForMove = e.Location;
                    }
                }
                else
                {
                    switch (_relationshipsType)
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

                    if (_actionType == ActionType.DrawRelationship)
                    {
                        _currentRelationship.StartPoint = e.Location;
                    }
                    if (_actionType == ActionType.DrawUmlClass)
                    {
                        _UMLClass = new UMLClass();
                        _UMLClass.StartPoint = e.Location;
                    }
                }

                _isMouseMove = true;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseMove)
            {
                if (_isClickedMoveButton)
                {
                    _currentRelationship.Move(e.X - _pointForMove.X, e.Y - _pointForMove.Y);
                    _pointForMove = e.Location;
                }
                else
                {
                    if (_actionType == ActionType.DrawRelationship)
                    {
                        _currentRelationship.EndPoint = e.Location;
                    }
                    else if (_actionType == ActionType.DrawUmlClass)
                    {
                        _UMLClass.EndPoint = e.Location;
                    }
                }

                pictureBox1.Invalidate();
            }

            
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isMouseMove)
            {
                if (_actionType == ActionType.DrawRelationship)
                {
                    _listRelationships.Add(_currentRelationship);
                }
                else if (_actionType == ActionType.DrawUmlClass)
                {
                    _listUMLClasses.Add(_UMLClass);
                }
            }

            _isMouseMove = false;
            _isClickedMoveButton = false;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (_isMouseMove)
            {
                _graphics.Clear(pictureBox1.BackColor);

                if (_actionType == ActionType.DrawRelationship)
                {
                    _currentRelationship.Draw(_graphics);
                }
                if (_actionType == ActionType.DrawUmlClass)
                {
                    _UMLClass.DrawUMLClass(_graphics);
                }
                foreach (var relation in _listRelationships)
                {
                    relation.Draw(_graphics);
                }
                foreach (var umlClass in _listUMLClasses)
                {
                    umlClass.DrawUMLClass(_graphics);
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            _isClickedMoveButton = true;
            _currentRelationship = null;
        }
    }
}
