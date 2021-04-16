using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UML_Diagram_Designer.Relationships;
using UML_Diagram_Designer.UMLClasses;
using UML_Diagram_Designer.FactoryClasses;
using UML_Diagram_Designer.FactoryClasses.RelationshipFactories;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UML_Diagram_Designer.Interfaces;

namespace UML_Diagram_Designer
{
    public partial class Form1 : Form
    {
        private Bitmap _mainBitmap;
        private Graphics _graphics;
        private AbstractRelationship _currentRelationship;
        bool _isMouseMoving = false;
        bool _isMoveButtonClicked = false;
        RelationshipType _relationshipsType = RelationshipType.Inharitance;
        ActionType _actionType;
        //private UMLClass _UMLClass;
        //List<AbstractRelationship> _listRelationships;
        //List<UMLClass> _listUMLClasses;
        List<ISelectable> _listAllObjects;
        Point _pointForMove;
        private int _width = 6;
        private Color _color = Color.Black;
        private ISelectable _umlObject;
        private Painter painter2d;




        AbstractDiagramElement _currentDiagramElement;
        List<AbstractDiagramElement> lstAbstractDiagramElements;
        AbstractDiagramElementFactory _currentFactory;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            painter2d = Painter.GetPainter(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = painter2d._bitmap;
            lstAbstractDiagramElements = new List<AbstractDiagramElement>();
            //_listRelationships = new List<AbstractRelationship>();
            //_listUMLClasses = new List<UMLClass>();
            _listAllObjects = new List<ISelectable>();
        }
        private void associationButton_Click(object sender, EventArgs e)
        {
            _currentFactory= new AssociationRelationshipFactory();
            _currentDiagramElement = _currentFactory.GetElement();
            //_relationshipsType = RelationshipType.Association;
            //_actionType = ActionType.DrawRelationship;
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
            _isMouseMoving = false;
            _isMoveButtonClicked = false;
            _graphics.Clear(Color.White);
            //_listUMLClasses.Clear();
            //_listRelationships.Clear();
            _listAllObjects.Clear();
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                _currentDiagramElement = _currentFactory.GetElement();
                _currentDiagramElement.StartPoint = e.Location;
            }
            //    if (_isMoveButtonClicked)
            //    {
            //        foreach (var umlObject in _listAllObjects)
            //        {
            //            if (umlObject.CheckIfTheObjectIsClicked(e.Location))
            //            {
            //                if (umlObject is AbstractRelationship)
            //                {
            //                    _currentRelationship = (AbstractRelationship)umlObject;
            //                    _umlObject = umlObject;
            //                    break;
            //                }
            //                else if (umlObject is UMLClass)
            //                {
            //                    _UMLClass = (UMLClass)umlObject;
            //                    _umlObject = umlObject;
            //                    break;
            //                }
            //            }
            //        }

            //        if (_currentRelationship != null || _UMLClass != null)
            //        {
            //            if (_umlObject is AbstractRelationship)
            //            {
            //                _listAllObjects.Remove(_currentRelationship);

            //            }
            //            else if (_umlObject is UMLClass)
            //            {
            //                _listAllObjects.Remove(_UMLClass);
            //            }

            //            foreach (var umlObject in _listAllObjects)
            //            {
            //                if (umlObject is AbstractRelationship)
            //                {
            //                    _currentRelationship.Draw(_graphics);
            //                }
            //                else if (umlObject is UMLClass)
            //                {
            //                    _UMLClass.DrawUMLClass(_graphics);
            //                }
            //            }
                        _isMouseMoving = true;
            //            _pointForMove = e.Location;
            //        }
            //        else
            //        {
            //            _isMouseMoving = false;
            //        }
            //    }
            //    else
            //    {
            //        switch (_relationshipsType)
            //        {
            //            case RelationshipType.Aggregation:
            //                _currentRelationship = new AggregationRelationship(_color, _width);
            //                break;
            //            case RelationshipType.Association:
            //                _currentRelationship = new AssociationRelationship(_color, _width);
            //                break;
            //            case RelationshipType.Composition:
            //                _currentRelationship = new CompositionRelationship(_color, _width);
            //                break;
            //            case RelationshipType.Inharitance:
            //                _currentRelationship = new InheritanceRelationship(_color, _width);
            //                break;
            //            case RelationshipType.Realization:
            //                _currentRelationship = new RealizationRelationship(_color, _width);
            //                break;
            //        }

            //        if (_actionType == ActionType.DrawRelationship)
            //        {
            //            _currentRelationship.StartPoint = e.Location;
            //        }
            //        if (_actionType == ActionType.DrawUmlClass)
            //        {
            //            _UMLClass = new UMLClass(_color, _width);
            //            _UMLClass.StartPoint = e.Location;
            //        }

            //        _isMouseMoving = true;
            //    }
            //}
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseMoving == true)
            {
            _currentDiagramElement.EndPoint = e.Location;
            }
            pictureBox1.Invalidate();


            //if (_isMouseMoving)
            //{
            //    if (_isMoveButtonClicked && _currentRelationship != null)// TODO: think about actionType using
            //    {
            //        _currentRelationship.Move(e.X - _pointForMove.X, e.Y - _pointForMove.Y);
            //        _pointForMove = e.Location;
            //    }
            //    else if (_isMoveButtonClicked && _UMLClass != null)
            //    {
            //        _UMLClass.Move(e.X - _pointForMove.X, e.Y - _pointForMove.Y);
            //        _pointForMove = e.Location;
            //    }
            //    else
            //    {
            //        if (_actionType == ActionType.DrawRelationship)
            //        {
            //            _currentRelationship.EndPoint = e.Location;
            //        }
            //        else if (_actionType == ActionType.DrawUmlClass)
            //        {
            //            _UMLClass.EndPoint = e.Location;
            //        }
            //    }

            //    pictureBox1.Invalidate();
            //}
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (_isMouseMoving ==true)
            {
                painter2d._graphics.Clear(pictureBox1.BackColor);
                _currentDiagramElement.Draw(painter2d._graphics);

            }
            foreach (var element in lstAbstractDiagramElements)
            {
                element.Draw(painter2d._graphics);
            }

                //if (_isMouseMoving)
                //{
                //    _graphics.Clear(pictureBox1.BackColor);

                //    if (_actionType == ActionType.DrawRelationship)
                //    {
                //        _currentRelationship.Draw(_graphics);
                //    }
                //    if (_actionType == ActionType.DrawUmlClass)
                //    {
                //        _UMLClass.DrawUMLClass(_graphics);
                //    }
                //    foreach (var umlObject in _listAllObjects)
                //    {
                //        if (umlObject is AbstractRelationship)
                //        {
                //            AbstractRelationship arrow = (AbstractRelationship)umlObject;
                //            arrow.Draw(_graphics);
                //        }
                //        else if (umlObject is UMLClass)
                //        {
                //            UMLClass umlClass = (UMLClass)umlObject;
                //            umlClass.DrawUMLClass(_graphics);
                //        }
                //    }
                //}
            }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isMouseMoving)
            {
                lstAbstractDiagramElements.Add(_currentDiagramElement);
                //if (_actionType == ActionType.DrawRelationship)
                //{
                //    _listAllObjects.Add(_currentRelationship);
                //}
                //else if (_actionType == ActionType.DrawUmlClass)
                //{
                //    _listAllObjects.Add(_UMLClass);
                //}
            }

            _isMouseMoving = false;
            //_isMoveButtonClicked = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            _isMoveButtonClicked = true;
            _currentRelationship = null;
            //_UMLClass = null;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();

            if (colorDialog.Color == Color.Black)
            {
                colorButton.BackColor = Color.White;
            }
            else
            {
                colorButton.BackColor = colorDialog.Color;
            }
            _color = colorDialog.Color;
        }

        private void ThicknessTrackBar_Scroll(object sender, EventArgs e)
        {
            _width = thicknessTrackBar.Value;
        }
    }
}
