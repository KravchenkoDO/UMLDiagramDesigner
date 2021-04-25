using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using UML_Diagram_Designer.UMLClasses;
using UML_Diagram_Designer.HandlerClasses;
using UML_Diagram_Designer.FactoryClasses;
using UML_Diagram_Designer.FactoryClasses.ClassBlockFactories;
using UML_Diagram_Designer.FactoryClasses.RelationshipFactories;

namespace UML_Diagram_Designer
{
    public partial class Form1 : Form
    {
        bool isMouseMoving = false;
        private Canvas canvas;
        private AbstractDiagramElementFactory currentFactory;
        public List<string> currentClassTextList;
        private AbstractHandler currentHandler;
        private Point panelLocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelLocation = new Point(splitContainer1.Width + 1, menuStrip1.Height + 1);
            flowLayoutPanel1.Location = panelLocation;
            flowLayoutPanel1.Height = this.Height - menuStrip1.Height - 50;
            flowLayoutPanel1.Width = this.Width - splitContainer1.Width - 30;
            pictureBox1.Height = 1200;
            pictureBox1.Width = 1600;

            canvas = Canvas.GetCanvas();
            canvas.SetCanvas(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = canvas.bitmap;
            canvas.pictureBox = pictureBox1;
            canvas.listAbstractDiagramElements = new List<AbstractDiagramElement>();
            canvas.SetPenParameters(colorDialog.Color, thicknessTrackBar.Value);
            currentFactory = new AssociationRelationshipFactory();
            currentHandler = new DrawHandler(currentFactory);
        }

        private void associationButton_Click(object sender, EventArgs e)
        {
            currentFactory = new AssociationRelationshipFactory();
            currentHandler = new DrawHandler(currentFactory);
        }

        private void inheritanceButton_Click(object sender, EventArgs e)
        {
            currentFactory = new InheritanceRelationshipFactory();
            currentHandler = new DrawHandler(currentFactory);
        }

        private void realizationButton_Click(object sender, EventArgs e)
        {
            currentFactory = new RealizationRelationshipFactory();
            currentHandler = new DrawHandler(currentFactory);
        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            currentFactory = new AggregationRelationshipFactory();
            currentHandler = new DrawHandler(currentFactory);
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {
            currentFactory = new CompositionRelationshipFactory();
            currentHandler = new DrawHandler(currentFactory);
        }

        private void InterFaceButton_Click(object sender, EventArgs e)
        {
            currentFactory = new UMLInterfaceFactory();
            currentHandler = new DrawHandler(currentFactory);
        }

        private void BtnStack_Click(object sender, EventArgs e)
        {
            currentFactory = new UMLStackFactory();
            currentHandler = new DrawHandler(currentFactory);
        }

        private void BtnClass_Click(object sender, EventArgs e)
        {
            currentFactory = new UMLClassFactory();
            currentHandler = new DrawHandler(currentFactory);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            isMouseMoving = false;
            canvas.graphics.Clear(Color.White);
            canvas.listAbstractDiagramElements.Clear();
            canvas.pictureBox.Invalidate();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(currentHandler is null))
            {
                if (e.Button == MouseButtons.Left)
                {
                    currentHandler.MouseDown(e);
                    isMouseMoving = true;
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(currentHandler is null))
            {
                currentHandler.MouseMove(e.Location);
                canvas.pictureBox.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isMouseMoving)
            {
                currentHandler.Paint();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!(currentHandler is null))
            {
                if (e.Button == MouseButtons.Left)
                {
                    currentHandler.MouseUp();
                    isMouseMoving = false;
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!(currentHandler is null))
            {
                if (e.Button == MouseButtons.Left)
                {
                    currentHandler.MouseClick(e);
                }

                if (e.Button == MouseButtons.Right)
                {
                    foreach (var element in canvas.listAbstractDiagramElements)
                    {
                        if (element is AbstractUMLElement)
                        {
                            AbstractUMLElement currentClass = (AbstractUMLElement)element;

                            if (currentClass.CheckIfTheObjectIsClicked(e.Location))
                            {
                                currentClassTextList = currentClass.CheckSelectedList();
                                    EditClassTextForm editClassTextForm = new EditClassTextForm(currentClassTextList);
                                    editClassTextForm.StartPosition = FormStartPosition.CenterParent;
                                    editClassTextForm.ShowDialog();
                            }
                        }
                    }
                }
            }

        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            currentHandler = new MoveHandler();
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            currentHandler = new DeleteHandler();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            currentHandler = new ChangeColorAndSizeHandler();
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            if (!String.IsNullOrEmpty("lol") && fontDialog1.ShowDialog() == DialogResult.OK)
            {
                canvas.Font = fontDialog1.Font;
                canvas.graphics.Clear(Color.White);
                canvas.RedrawElementsFromElementsList();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentHandler = null;
            openDeserializeFileDialog.Title = "Open UML File";
            openDeserializeFileDialog.Filter = "UML files(*.uml)|*.uml";
            if (openDeserializeFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileData = SaveOrLoad.OpenFile(openDeserializeFileDialog.FileName);
                JsonDeserialized(fileData);
                canvas.RedrawElementsFromElementsList();
                pictureBox1.Invalidate();
                colorButton.BackColor = Color.White;
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

            currentHandler = null;
        }

        public string JsonSerialized()
        {
            string fileSerialized = JsonConvert.SerializeObject(canvas.listAbstractDiagramElements, Formatting.Indented,
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto
                    });
            return fileSerialized;
        }

        public void JsonDeserialized(string fileSerialized)
        {
            canvas.listAbstractDiagramElements = JsonConvert.DeserializeObject<List<AbstractDiagramElement>>(fileSerialized,
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto
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
            currentHandler = changeColorAndSizeHandler;
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
