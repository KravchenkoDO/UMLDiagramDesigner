﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using UML_Diagram_Designer.FactoryClasses;
using UML_Diagram_Designer.FactoryClasses.ClassBlockFactories;
using UML_Diagram_Designer.FactoryClasses.RelationshipFactories;

namespace UML_Diagram_Designer
{
    public partial class Form1 : Form
    {
        bool _isMouseMoving = false;
        bool _isMoveButtonClicked = false;
        bool _isSelect = false;
        Point _pointForMove;
        private int _width = 6;
        private Color _color = Color.Black;
        private Canvas canvas;
        AbstractDiagramElement _currentDiagramElement;
        List<AbstractDiagramElement> listAbstractDiagramElements;
        AbstractDiagramElementFactory _currentFactory;
        public List<string> _currentClassTextList;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = Canvas.GetCanvas();
            canvas.SetCanvas(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = canvas._bitmap;
            listAbstractDiagramElements = new List<AbstractDiagramElement>();
            _currentFactory = new AssociationRelationshipFactory();
        }
        private void associationButton_Click(object sender, EventArgs e)
        {
            _currentFactory = new AssociationRelationshipFactory();
        }
        private void inheritanceButton_Click(object sender, EventArgs e)
        {
            _currentFactory = new InheritanceRelationshipFactory();
        }
        private void realizationButton_Click(object sender, EventArgs e)
        {
            _currentFactory = new RealizationRelationshipFactory();
        }
        private void aggregationButton_Click(object sender, EventArgs e)
        {
            _currentFactory = new AggregationRelationshipFactory();
        }
        private void compositionButton_Click(object sender, EventArgs e)
        {
            _currentFactory = new CompositionRelationshipFactory();
        }
        private void classButton_Click(object sender, EventArgs e)
        {
            _isSelect = false;

            _currentFactory = new UMLClassFactory();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            _isMouseMoving = false;
            _isMoveButtonClicked = false;
            canvas._graphics.Clear(Color.White);
            listAbstractDiagramElements.Clear();
            pictureBox1.Invalidate();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _currentDiagramElement = null;
            if (_isSelect)
            {
                foreach (var element in listAbstractDiagramElements)
                {
                    if (element.CheckIfTheObjectIsClicked(e.Location))
                    {
                        _currentDiagramElement = element;
                        break;
                    }
                }
            }
            else if (_isMoveButtonClicked)
            {
                foreach (var element in listAbstractDiagramElements)
                {
                    if (element.CheckIfTheObjectIsClicked(e.Location))
                    {
                        _currentDiagramElement = element;
                        listAbstractDiagramElements.Remove(element);
                        break;
                    }
                }
                _pointForMove = e.Location;
                _isMouseMoving = true;
            }
            else if (e.Button == MouseButtons.Left)
            {
                canvas.SetPenParameters(colorDialog.Color, thicknessTrackBar.Value);
                _currentDiagramElement = _currentFactory.GetElement(canvas.PenColor, canvas.PenSize);
                _currentDiagramElement.StartPoint = e.Location;
                _isMouseMoving = true;
            }
            _isSelect = false;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseMoving)
            {
                if (_isMoveButtonClicked)
                {
                    if (!(_currentDiagramElement is null))
                    {
                        _currentDiagramElement.Move(e.X - _pointForMove.X, e.Y - _pointForMove.Y);
                        _pointForMove = e.Location;
                    }
                }
                else
                {
                    _currentDiagramElement.EndPoint = e.Location;
                }
                pictureBox1.Invalidate();
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (_isMouseMoving == true)
            {
                if (!(_currentDiagramElement is null))
                {
                    canvas.SetPenParameters(_currentDiagramElement.ObjectPenColor, _currentDiagramElement.ObjectPenWidth);
                    canvas._graphics.Clear(pictureBox1.BackColor);
                    _currentDiagramElement.Draw(canvas);
                }
                foreach (var element in listAbstractDiagramElements)
                {
                    canvas.SetPenParameters(element.ObjectPenColor, element.ObjectPenWidth);
                    element.Draw(canvas);
                }
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isMouseMoving)
            {
                listAbstractDiagramElements.Add(_currentDiagramElement);
            }
            _isMoveButtonClicked = false;
            _isMouseMoving = false;
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            _isMoveButtonClicked = true;
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
            _currentClassTextList = _currentDiagramElement.SaveElementText(textBox1.Text);
            pictureBox1.Invalidate();
        }

        private void BtnSelectElement_Click(object sender, EventArgs e)
        {
            _isSelect = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (var element in listAbstractDiagramElements)
                {
                    if (element.CheckIfTheObjectIsClicked(e.Location))
                    {
                        _currentDiagramElement = element;
                        listAbstractDiagramElements.Remove(element);
                        break;
                    }
                }

                if (!(_currentDiagramElement is null))
                {
                    _currentDiagramElement.ObjectPenColor = colorDialog.Color;
                    _currentDiagramElement.ObjectPenWidth = thicknessTrackBar.Value;
                    listAbstractDiagramElements.Add(_currentDiagramElement);
                    _currentDiagramElement.Draw(canvas);
                    pictureBox1.Invalidate();
                }
            }
        }

        private void btnEditClassText_Click(object sender, EventArgs e)
        {
            if (!(_currentClassTextList is null))
            {
                EditClassTextForm editClassTextForm = new EditClassTextForm(_currentClassTextList);
                editClassTextForm.ShowDialog();
            }
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            if (!String.IsNullOrEmpty(textBox1.Text) && fontDialog1.ShowDialog() == DialogResult.OK)
            {
                canvas.Font = fontDialog1.Font;
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveSerializeFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveSerializeFileDialog.FileName != null)
                {

                    string filename = saveSerializeFileDialog.FileName;
                    string jsonString = JsonSerializer.Serialize(listAbstractDiagramElements);
                    jsonString = JsonSerializer.Serialize(listAbstractDiagramElements);
                    File.WriteAllText(filename, jsonString);
                    //FileStream fileStream = new FileStream(filename, FileMode.OpenOrCreate);
                    //JsonSerializer.Serialize<List<AbstractDiagramElement>>(fileStream, listAbstractDiagramElements);
                    MessageBox.Show("Data has been saved to file!!!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openDeserializeFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openDeserializeFileDialog.FileName != null)
                {
                    string filename = openDeserializeFileDialog.FileName;
                    string jsonString = File.ReadAllText(filename);
                    listAbstractDiagramElements = JsonSerializer.Deserialize<List<AbstractDiagramElement>>(jsonString);
                    MessageBox.Show("Data has been opened from file!!!");
                }
            }
        }
    }
}
