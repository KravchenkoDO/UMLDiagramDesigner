
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTextBoxEnter = new System.Windows.Forms.Button();
            this.btnSelectElement = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditClassText = new System.Windows.Forms.Button();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStack = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(208, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 506);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(-2, 544);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(76, 34);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear all";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // compositionButton
            // 
            this.compositionButton.Location = new System.Drawing.Point(106, 106);
            this.compositionButton.Name = "compositionButton";
            this.compositionButton.Size = new System.Drawing.Size(89, 33);
            this.compositionButton.TabIndex = 13;
            this.compositionButton.Text = "Композиция";
            this.compositionButton.UseVisualStyleBackColor = true;
            this.compositionButton.Click += new System.EventHandler(this.compositionButton_Click);
            // 
            // aggregationButton
            // 
            this.aggregationButton.Location = new System.Drawing.Point(57, 68);
            this.aggregationButton.Name = "aggregationButton";
            this.aggregationButton.Size = new System.Drawing.Size(87, 33);
            this.aggregationButton.TabIndex = 12;
            this.aggregationButton.Text = "Агрегация";
            this.aggregationButton.UseVisualStyleBackColor = true;
            this.aggregationButton.Click += new System.EventHandler(this.aggregationButton_Click);
            // 
            // realizationButton
            // 
            this.realizationButton.Location = new System.Drawing.Point(10, 106);
            this.realizationButton.Name = "realizationButton";
            this.realizationButton.Size = new System.Drawing.Size(86, 33);
            this.realizationButton.TabIndex = 10;
            this.realizationButton.Text = "Реализация";
            this.realizationButton.UseVisualStyleBackColor = true;
            this.realizationButton.Click += new System.EventHandler(this.realizationButton_Click);
            // 
            // inheritanceButton
            // 
            this.inheritanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inheritanceButton.Location = new System.Drawing.Point(106, 27);
            this.inheritanceButton.Name = "inheritanceButton";
            this.inheritanceButton.Size = new System.Drawing.Size(89, 35);
            this.inheritanceButton.TabIndex = 9;
            this.inheritanceButton.Text = "Наследование";
            this.inheritanceButton.UseVisualStyleBackColor = true;
            this.inheritanceButton.Click += new System.EventHandler(this.inheritanceButton_Click);
            // 
            // associationButton
            // 
            this.associationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.associationButton.Location = new System.Drawing.Point(9, 27);
            this.associationButton.Name = "associationButton";
            this.associationButton.Size = new System.Drawing.Size(87, 35);
            this.associationButton.TabIndex = 8;
            this.associationButton.Text = "Ассоциация";
            this.associationButton.UseVisualStyleBackColor = true;
            this.associationButton.Click += new System.EventHandler(this.associationButton_Click);
            // 
            // btnInterface
            // 
            this.btnInterface.Location = new System.Drawing.Point(9, 154);
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.Size = new System.Drawing.Size(65, 45);
            this.btnInterface.TabIndex = 15;
            this.btnInterface.Text = "Interface";
            this.btnInterface.UseVisualStyleBackColor = true;
            this.btnInterface.Click += new System.EventHandler(this.InterFaceButton_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(106, 219);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(89, 34);
            this.buttonMove.TabIndex = 16;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(10, 269);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(86, 33);
            this.colorButton.TabIndex = 17;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // thicknessTrackBar
            // 
            this.thicknessTrackBar.Location = new System.Drawing.Point(10, 319);
            this.thicknessTrackBar.Minimum = 2;
            this.thicknessTrackBar.Name = "thicknessTrackBar";
            this.thicknessTrackBar.Size = new System.Drawing.Size(187, 45);
            this.thicknessTrackBar.TabIndex = 18;
            this.thicknessTrackBar.Value = 2;
            this.thicknessTrackBar.Scroll += new System.EventHandler(this.ThicknessTrackBar_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 410);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 19;
            // 
            // btnTextBoxEnter
            // 
            this.btnTextBoxEnter.Location = new System.Drawing.Point(9, 436);
            this.btnTextBoxEnter.Name = "btnTextBoxEnter";
            this.btnTextBoxEnter.Size = new System.Drawing.Size(86, 32);
            this.btnTextBoxEnter.TabIndex = 20;
            this.btnTextBoxEnter.Text = "Enter";
            this.btnTextBoxEnter.UseVisualStyleBackColor = true;
            this.btnTextBoxEnter.Click += new System.EventHandler(this.BtnTextBoxEnter_Click);
            // 
            // btnSelectElement
            // 
            this.btnSelectElement.Location = new System.Drawing.Point(109, 485);
            this.btnSelectElement.Name = "btnSelectElement";
            this.btnSelectElement.Size = new System.Drawing.Size(88, 31);
            this.btnSelectElement.TabIndex = 21;
            this.btnSelectElement.Text = "SelectElement";
            this.btnSelectElement.UseVisualStyleBackColor = true;
            this.btnSelectElement.Click += new System.EventHandler(this.BtnSelectElement_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(11, 485);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 31);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete Elem";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEditClassText
            // 
            this.btnEditClassText.Location = new System.Drawing.Point(109, 436);
            this.btnEditClassText.Name = "btnEditClassText";
            this.btnEditClassText.Size = new System.Drawing.Size(88, 32);
            this.btnEditClassText.TabIndex = 22;
            this.btnEditClassText.Text = "EditClassText";
            this.btnEditClassText.UseVisualStyleBackColor = true;
            this.btnEditClassText.Click += new System.EventHandler(this.btnEditClassText_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(106, 269);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(89, 34);
            this.btnFont.TabIndex = 22;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uMLToolStripMenuItem,
            this.jPGToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // uMLToolStripMenuItem
            // 
            this.uMLToolStripMenuItem.Name = "uMLToolStripMenuItem";
            this.uMLToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.uMLToolStripMenuItem.Text = "UML";
            this.uMLToolStripMenuItem.Click += new System.EventHandler(this.uMLToolStripMenuItem_Click);
            // 
            // jPGToolStripMenuItem
            // 
            this.jPGToolStripMenuItem.Name = "jPGToolStripMenuItem";
            this.jPGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.jPGToolStripMenuItem.Text = "JPG";
            this.jPGToolStripMenuItem.Click += new System.EventHandler(this.jPGToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(9, 219);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 34);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "EditElem";
            this.btnEdit.UseVisualStyleBackColor = true;
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
            this.comboBox1.Location = new System.Drawing.Point(11, 369);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Text = "Choose relationship type";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(80, 154);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(51, 45);
            this.btnStack.TabIndex = 27;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.BtnStack_Click);
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(137, 154);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(65, 45);
            this.btnClass.TabIndex = 28;
            this.btnClass.Text = "Class";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.BtnClass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 583);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditClassText);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnSelectElement);
            this.Controls.Add(this.btnTextBoxEnter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.thicknessTrackBar);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.btnInterface);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.compositionButton);
            this.Controls.Add(this.aggregationButton);
            this.Controls.Add(this.realizationButton);
            this.Controls.Add(this.inheritanceButton);
            this.Controls.Add(this.associationButton);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "UML Diagram Designer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTextBoxEnter;
        private System.Windows.Forms.Button btnSelectElement;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditClassText;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnClass;
    }
}

