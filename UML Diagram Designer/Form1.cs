using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UML_Diagram_Designer.HandlerClasses;
using UML_Diagram_Designer.FactoryClasses;
using UML_Diagram_Designer.FactoryClasses.ClassBlockFactories;
using UML_Diagram_Designer.FactoryClasses.RelationshipFactories;

namespace UML_Diagram_Designer
{
    public partial class Form1 : Form
    {
        bool _isMouseMoving = false;
        //bool _isMoveButtonClicked = false;
        //bool _isSelect = false;
        //Point _pointForMove;
        //private int _width = 6;
        //private Color _color = Color.Black;
        private Canvas canvas;
        AbstractDiagramElement _selectedElement;
        AbstractDiagramElementFactory _currentFactory;
        AbstractHandler _currentHandler;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = Canvas.GetCanvas();
            canvas.SetCanvas(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = canvas._bitmap;
            canvas._pictureBox = pictureBox1;
            canvas._listAbstractDiagramElements = new List<AbstractDiagramElement>();
            canvas.SetPenParameters(colorDialog.Color, thicknessTrackBar.Value);
            _currentFactory = new AssociationRelationshipFactory();
            _currentHandler = new DrawHandler(_currentFactory);

        }
        private void associationButton_Click(object sender, EventArgs e)
        {
            _currentFactory = new AssociationRelationshipFactory();
            _currentHandler = new DrawHandler(_currentFactory);
        }
        private void inheritanceButton_Click(object sender, EventArgs e)
        {
            _currentFactory = new InheritanceRelationshipFactory();
            _currentHandler = new DrawHandler(_currentFactory);
        }
        private void realizationButton_Click(object sender, EventArgs e)
        {
            _currentFactory = new RealizationRelationshipFactory();
            _currentHandler = new DrawHandler(_currentFactory);
        }
        private void aggregationButton_Click(object sender, EventArgs e)
        {
            _currentFactory = new AggregationRelationshipFactory();
            _currentHandler = new DrawHandler(_currentFactory);
        }
        private void compositionButton_Click(object sender, EventArgs e)
        {
            _currentFactory = new CompositionRelationshipFactory();
            _currentHandler = new DrawHandler(_currentFactory);
        }
        private void classButton_Click(object sender, EventArgs e)
        {
            //_isSelect = false;

            _currentFactory = new UMLClassFactory();
            _currentHandler = new DrawHandler(_currentFactory);
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            _isMouseMoving = false;
            //_isMoveButtonClicked = false;
            canvas._graphics.Clear(Color.White);
            canvas._listAbstractDiagramElements.Clear();
            canvas._pictureBox.Invalidate();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _currentHandler.MouseDown(e.Location);

            //_currentDiagramElement = null;
            //if (_isSelect)
            //{
            //    foreach (var element in canvas.listAbstractDiagramElements)
            //    {
            //        if (element.CheckIfTheObjectIsClicked(e.Location))
            //        {
            //            _currentDiagramElement = element;
            //            break;
            //        }
            //    }
            //}
            //else if (_isMoveButtonClicked)
            //{
            //    foreach (var element in canvas.listAbstractDiagramElements)
            //    {
            //        if (element.CheckIfTheObjectIsClicked(e.Location))
            //        {
            //            _currentDiagramElement = element;
            //            canvas.listAbstractDiagramElements.Remove(element);
            //            break;
            //        }
            //    }
            //_pointForMove = e.Location;
            //_isMouseMoving = true;
            //}
            //else if (e.Button == MouseButtons.Left)
            //{
            //    canvas.SetPenParameters(colorDialog.Color, thicknessTrackBar.Value);
            //    _currentDiagramElement = _currentFactory.GetElement(canvas.PenColor, canvas.PenSize);
            //    _currentDiagramElement.StartPoint = e.Location;
            _isMouseMoving = true;
            //}
            //_isSelect = false;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _currentHandler.MouseMove(e.Location);

            //else if (_isMouseMoving)
            //{
            //    if (_isMoveButtonClicked)
            //    {
            //        if (!(_currentDiagramElement is null))
            //        {
            //            _currentDiagramElement.Move(e.X - _pointForMove.X, e.Y - _pointForMove.Y);
            //            _pointForMove = e.Location;
            //        }
            //    }
            //else
            //{
            //    _currentDiagramElement.EndPoint = e.Location;
            //}
            canvas._pictureBox.Invalidate();

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (_isMouseMoving)
            {
                _currentHandler.Paint();
            }
            //{
            //    if (!(_currentDiagramElement is null))
            //    {
            //        canvas.SetPenParameters(_currentDiagramElement.ObjectPenColor, _currentDiagramElement.ObjectPenWidth);
            //        canvas._graphics.Clear(pictureBox1.BackColor);
            //        _currentDiagramElement.Draw(canvas);
            //    }
            //    foreach (var element in canvas.listAbstractDiagramElements)
            //    {
            //        canvas.SetPenParameters(element.ObjectPenColor, element.ObjectPenWidth);
            //        element.Draw(canvas);
            //    }
            //}
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _currentHandler.MouseUp();
            //if (_isMouseMoving)
            //{
            //    canvas.listAbstractDiagramElements.Add(_currentDiagramElement);
            //}
            //_isMoveButtonClicked = false;
            _isMouseMoving = false;
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //_isMoveButtonClicked = true;
            _currentHandler = new MoveHandler();
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

            canvas.PenColor = colorDialog.Color;
        }
        private void ThicknessTrackBar_Scroll(object sender, EventArgs e)
        {
            canvas.PenSize = thicknessTrackBar.Value;
        }

        private void BtnTextBoxEnter_Click(object sender, EventArgs e)
        {
            //_currentDiagramElement.SaveElementText(textBox1.Text);
            canvas._pictureBox.Invalidate();
        }

        private void BtnSelectElement_Click(object sender, EventArgs e)
        {
            //_isSelect = true;
            _currentHandler = new SelectHandler();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _currentHandler = new DeleteHandler();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            _currentHandler.MouseClick(e.Location);

            if (!(_currentHandler.ReturnElement() is null))
            {
                _selectedElement = _currentHandler.ReturnElement();
            }
            //    if (e.Button == MouseButtons.Left)
            //    {
            //        foreach (var element in canvas._listAbstractDiagramElements)
            //        {
            //            if (element.CheckIfTheObjectIsClicked(e.Location))
            //            {
            //                _currentDiagramElement = element;
            //                canvas._listAbstractDiagramElements.Remove(element);
            //                break;
            //            }
            //        }

            //        if (!(_currentDiagramElement is null))
            //        {
            //            _currentDiagramElement.ObjectPenColor = colorDialog.Color;
            //            _currentDiagramElement.ObjectPenWidth = thicknessTrackBar.Value;
            //            canvas._listAbstractDiagramElements.Add(_currentDiagramElement);
            //            _currentDiagramElement.Draw(canvas);
            //            canvas._pictureBox.Invalidate();
            //        }
            //    }
        }

        
    }
}
