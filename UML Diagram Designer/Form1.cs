using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Newtonsoft.Json;
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
        private Canvas canvas;
        AbstractDiagramElement _selectedElement;
        AbstractDiagramElementFactory _currentFactory;
        public List<string> _currentClassTextList;
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
            _currentFactory = new UMLClassFactory();
            _currentHandler = new DrawHandler(_currentFactory);
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            _isMouseMoving = false;
            canvas._graphics.Clear(Color.White);
            canvas._listAbstractDiagramElements.Clear();
            canvas._pictureBox.Invalidate();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _currentHandler.MouseDown(e);
            _isMouseMoving = true;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _currentHandler.MouseMove(e.Location);
            canvas._pictureBox.Invalidate();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (_isMouseMoving)
            {
                _currentHandler.Paint();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _currentHandler.MouseUp();
            _isMouseMoving = false;
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _currentHandler.MouseClick(e);

                if (!(_currentHandler.ReturnElement() is null))
                {
                    _selectedElement = _currentHandler.ReturnElement();
                }
            }
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
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
            _currentClassTextList = _selectedElement.SaveElementText(textBox1.Text);
            canvas._pictureBox.Invalidate();
        }

        private void BtnSelectElement_Click(object sender, EventArgs e)
        {
            _currentHandler = new SelectHandler();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _currentHandler = new DeleteHandler();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            _currentHandler = new ChangeColorAndSizeHandler();
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDeserializeFileDialog.Title = "Open UML File";
            openDeserializeFileDialog.Filter = "UML files(*.uml)|*.uml";
            if (openDeserializeFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileData=SaveOrLoad.OpenFile(openDeserializeFileDialog.FileName);
                JsonDeserialized(fileData);
                canvas.RedrawElementsFromElementsList();
            }
        }

        private void uMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSerializeFileDialog.Title = "Save UML File";
            saveSerializeFileDialog.Filter = "UML files(*.uml)|*.uml";
            if (saveSerializeFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveSerializeFileDialog.FileName != string.Empty)
                {
                    string fileData = JsonSerialized();
                    SaveOrLoad.SaveFile(saveSerializeFileDialog.FileName, fileData);
                }
            }
        }

        public string JsonSerialized()
        {
            string fileSerialized = JsonConvert.SerializeObject(canvas._listAbstractDiagramElements, Formatting.Indented,
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    });
            return fileSerialized;
        }

        public void JsonDeserialized(string fileSerialized)
        {
            canvas._listAbstractDiagramElements = JsonConvert.DeserializeObject<List<AbstractDiagramElement>>(fileSerialized,
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    });
        }

        private void jPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSerializeFileDialog.Filter = "JPG Image(*.jpeg)|*.jpg|BMP Image(*.bmp)|*.bmp";
            saveSerializeFileDialog.Title = "Save Image File";
            if (saveSerializeFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveSerializeFileDialog.FileName != string.Empty)
                {
                    pictureBox1.Image.Save(saveSerializeFileDialog.FileName);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FactoryChanger factoryChanger = new FactoryChanger(comboBox1.Text);
            ChangeColorAndSizeHandler changeColorAndSizeHandler = new ChangeColorAndSizeHandler(factoryChanger.GetEditFactory());
            _currentHandler = changeColorAndSizeHandler;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Save the changes?", "Mesage", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                saveSerializeFileDialog.Title = "Save UML File";
                saveSerializeFileDialog.Filter = "UML files(*.uml)|*.uml";
                if (saveSerializeFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileData = JsonSerialized();
                    SaveOrLoad.SaveFile(saveSerializeFileDialog.FileName, fileData);
                }
            }
        }
    }
}

        
