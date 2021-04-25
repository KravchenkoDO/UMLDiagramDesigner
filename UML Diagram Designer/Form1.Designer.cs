
using System.Windows.Forms;

namespace UML_Diagram_Designer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clearButton = new System.Windows.Forms.Button();
            this.compositionButton = new System.Windows.Forms.Button();
            this.aggregationButton = new System.Windows.Forms.Button();
            this.realizationButton = new System.Windows.Forms.Button();
            this.inheritanceButton = new System.Windows.Forms.Button();
            this.associationButton = new System.Windows.Forms.Button();
            this.btnInterface = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.thicknessTrackBar = new System.Windows.Forms.TrackBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.saveSerializeFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDeserializeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(3, 195);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(191, 51);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear Picture";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // compositionButton
            // 
            this.compositionButton.BackColor = System.Drawing.SystemColors.Control;
            this.compositionButton.Location = new System.Drawing.Point(107, 91);
            this.compositionButton.Name = "compositionButton";
            this.compositionButton.Size = new System.Drawing.Size(89, 33);
            this.compositionButton.TabIndex = 13;
            this.compositionButton.Text = "Composition";
            this.compositionButton.UseVisualStyleBackColor = false;
            this.compositionButton.Click += new System.EventHandler(this.compositionButton_Click);
            // 
            // aggregationButton
            // 
            this.aggregationButton.BackColor = System.Drawing.SystemColors.Control;
            this.aggregationButton.Location = new System.Drawing.Point(55, 47);
            this.aggregationButton.Name = "aggregationButton";
            this.aggregationButton.Size = new System.Drawing.Size(87, 33);
            this.aggregationButton.TabIndex = 12;
            this.aggregationButton.Text = "Aggregation";
            this.aggregationButton.UseVisualStyleBackColor = false;
            this.aggregationButton.Click += new System.EventHandler(this.aggregationButton_Click);
            // 
            // realizationButton
            // 
            this.realizationButton.BackColor = System.Drawing.SystemColors.Control;
            this.realizationButton.Location = new System.Drawing.Point(5, 91);
            this.realizationButton.Name = "realizationButton";
            this.realizationButton.Size = new System.Drawing.Size(86, 33);
            this.realizationButton.TabIndex = 10;
            this.realizationButton.Text = "Realization";
            this.realizationButton.UseVisualStyleBackColor = false;
            this.realizationButton.Click += new System.EventHandler(this.realizationButton_Click);
            // 
            // inheritanceButton
            // 
            this.inheritanceButton.BackColor = System.Drawing.SystemColors.Control;
            this.inheritanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inheritanceButton.Location = new System.Drawing.Point(107, 3);
            this.inheritanceButton.Name = "inheritanceButton";
            this.inheritanceButton.Size = new System.Drawing.Size(89, 35);
            this.inheritanceButton.TabIndex = 9;
            this.inheritanceButton.Text = "Inheritance";
            this.inheritanceButton.UseVisualStyleBackColor = false;
            this.inheritanceButton.Click += new System.EventHandler(this.inheritanceButton_Click);
            // 
            // associationButton
            // 
            this.associationButton.BackColor = System.Drawing.SystemColors.Control;
            this.associationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.associationButton.Location = new System.Drawing.Point(5, 3);
            this.associationButton.Name = "associationButton";
            this.associationButton.Size = new System.Drawing.Size(87, 35);
            this.associationButton.TabIndex = 8;
            this.associationButton.Text = "Association";
            this.associationButton.UseVisualStyleBackColor = false;
            this.associationButton.Click += new System.EventHandler(this.associationButton_Click);
            // 
            // btnInterface
            // 
            this.btnInterface.BackColor = System.Drawing.SystemColors.Control;
            this.btnInterface.Location = new System.Drawing.Point(5, 137);
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.Size = new System.Drawing.Size(65, 45);
            this.btnInterface.TabIndex = 15;
            this.btnInterface.Text = "Interface";
            this.btnInterface.UseVisualStyleBackColor = false;
            this.btnInterface.Click += new System.EventHandler(this.InterFaceButton_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMove.Location = new System.Drawing.Point(106, 3);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(90, 35);
            this.buttonMove.TabIndex = 16;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = false;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.SystemColors.Control;
            this.colorButton.Location = new System.Drawing.Point(7, 106);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(90, 35);
            this.colorButton.TabIndex = 17;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // thicknessTrackBar
            // 
            this.thicknessTrackBar.Location = new System.Drawing.Point(3, 147);
            this.thicknessTrackBar.Minimum = 2;
            this.thicknessTrackBar.Name = "thicknessTrackBar";
            this.thicknessTrackBar.Size = new System.Drawing.Size(191, 42);
            this.thicknessTrackBar.TabIndex = 18;
            this.thicknessTrackBar.Value = 2;
            this.thicknessTrackBar.Scroll += new System.EventHandler(this.ThicknessTrackBar_Scroll);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(5, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 31);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete Elem";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.SystemColors.Control;
            this.btnFont.Location = new System.Drawing.Point(106, 106);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(90, 35);
            this.btnFont.TabIndex = 22;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // saveSerializeFileDialog
            // 
            this.saveSerializeFileDialog.Filter = "UML files|*.uml";
            this.saveSerializeFileDialog.Title = "Save UML File";
            // 
            // openDeserializeFileDialog
            // 
            this.openDeserializeFileDialog.Filter = "UML files|*.uml";
            this.openDeserializeFileDialog.Title = "Open UML File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uMLToolStripMenuItem,
            this.jPGToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // uMLToolStripMenuItem
            // 
            this.uMLToolStripMenuItem.Name = "uMLToolStripMenuItem";
            this.uMLToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.uMLToolStripMenuItem.Text = "UML";
            this.uMLToolStripMenuItem.Click += new System.EventHandler(this.uMLToolStripMenuItem_Click);
            // 
            // jPGToolStripMenuItem
            // 
            this.jPGToolStripMenuItem.Name = "jPGToolStripMenuItem";
            this.jPGToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.jPGToolStripMenuItem.Text = "JPG";
            this.jPGToolStripMenuItem.Click += new System.EventHandler(this.jPGToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Location = new System.Drawing.Point(7, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 35);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "EditElem";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Association",
            "Inheritance",
            "Realization",
            "Composition",
            "Aggregation"});
            this.comboBox1.Location = new System.Drawing.Point(5, 80);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Text = "Choose relationship type";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnStack
            // 
            this.btnStack.BackColor = System.Drawing.SystemColors.Control;
            this.btnStack.Location = new System.Drawing.Point(74, 137);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(51, 45);
            this.btnStack.TabIndex = 27;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = false;
            this.btnStack.Click += new System.EventHandler(this.BtnStack_Click);
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.SystemColors.Control;
            this.btnClass.Location = new System.Drawing.Point(131, 137);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(65, 45);
            this.btnClass.TabIndex = 28;
            this.btnClass.Text = "Class";
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.BtnClass_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.inheritanceButton);
            this.splitContainer1.Panel1.Controls.Add(this.associationButton);
            this.splitContainer1.Panel1.Controls.Add(this.btnClass);
            this.splitContainer1.Panel1.Controls.Add(this.btnInterface);
            this.splitContainer1.Panel1.Controls.Add(this.realizationButton);
            this.splitContainer1.Panel1.Controls.Add(this.compositionButton);
            this.splitContainer1.Panel1.Controls.Add(this.btnStack);
            this.splitContainer1.Panel1.Controls.Add(this.aggregationButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.clearButton);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.thicknessTrackBar);
            this.splitContainer1.Panel2.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel2.Controls.Add(this.buttonMove);
            this.splitContainer1.Panel2.Controls.Add(this.btnFont);
            this.splitContainer1.Panel2.Controls.Add(this.colorButton);
            this.splitContainer1.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Size = new System.Drawing.Size(200, 597);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 152);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(202, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1138, 716);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1135, 716);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1366, 753);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UML Diagram Designer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button compositionButton;
        private System.Windows.Forms.Button aggregationButton;
        private System.Windows.Forms.Button realizationButton;
        private System.Windows.Forms.Button inheritanceButton;
        private System.Windows.Forms.Button associationButton;
        private System.Windows.Forms.Button btnInterface;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.TrackBar thicknessTrackBar;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.SaveFileDialog saveSerializeFileDialog;
        private System.Windows.Forms.OpenFileDialog openDeserializeFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPGToolStripMenuItem;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnClass;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
    }
}

