
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.compositionButton = new System.Windows.Forms.Button();
            this.aggregationButton = new System.Windows.Forms.Button();
            this.realizationButton = new System.Windows.Forms.Button();
            this.inheritanceButton = new System.Windows.Forms.Button();
            this.associationButton = new System.Windows.Forms.Button();
            this.classButton = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.thicknessTrackBar = new System.Windows.Forms.TrackBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(205, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 481);
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
            this.clearButton.Location = new System.Drawing.Point(9, 229);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(190, 43);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // compositionButton
            // 
            this.compositionButton.Location = new System.Drawing.Point(108, 69);
            this.compositionButton.Name = "compositionButton";
            this.compositionButton.Size = new System.Drawing.Size(94, 50);
            this.compositionButton.TabIndex = 13;
            this.compositionButton.Text = "Композиция";
            this.compositionButton.UseVisualStyleBackColor = true;
            this.compositionButton.Click += new System.EventHandler(this.compositionButton_Click);
            // 
            // aggregationButton
            // 
            this.aggregationButton.Location = new System.Drawing.Point(12, 124);
            this.aggregationButton.Name = "aggregationButton";
            this.aggregationButton.Size = new System.Drawing.Size(90, 50);
            this.aggregationButton.TabIndex = 12;
            this.aggregationButton.Text = "Агрегация";
            this.aggregationButton.UseVisualStyleBackColor = true;
            this.aggregationButton.Click += new System.EventHandler(this.aggregationButton_Click);
            // 
            // realizationButton
            // 
            this.realizationButton.Location = new System.Drawing.Point(12, 68);
            this.realizationButton.Name = "realizationButton";
            this.realizationButton.Size = new System.Drawing.Size(90, 50);
            this.realizationButton.TabIndex = 10;
            this.realizationButton.Text = "Реализация";
            this.realizationButton.UseVisualStyleBackColor = true;
            this.realizationButton.Click += new System.EventHandler(this.realizationButton_Click);
            // 
            // inheritanceButton
            // 
            this.inheritanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inheritanceButton.Location = new System.Drawing.Point(108, 13);
            this.inheritanceButton.Name = "inheritanceButton";
            this.inheritanceButton.Size = new System.Drawing.Size(94, 50);
            this.inheritanceButton.TabIndex = 9;
            this.inheritanceButton.Text = "Наследование";
            this.inheritanceButton.UseVisualStyleBackColor = true;
            this.inheritanceButton.Click += new System.EventHandler(this.inheritanceButton_Click);
            // 
            // associationButton
            // 
            this.associationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.associationButton.Location = new System.Drawing.Point(12, 12);
            this.associationButton.Name = "associationButton";
            this.associationButton.Size = new System.Drawing.Size(90, 50);
            this.associationButton.TabIndex = 8;
            this.associationButton.Text = "Ассоциация";
            this.associationButton.UseVisualStyleBackColor = true;
            this.associationButton.Click += new System.EventHandler(this.associationButton_Click);
            // 
            // classButton
            // 
            this.classButton.Location = new System.Drawing.Point(12, 181);
            this.classButton.Name = "classButton";
            this.classButton.Size = new System.Drawing.Size(190, 42);
            this.classButton.TabIndex = 15;
            this.classButton.Text = "Класс";
            this.classButton.UseVisualStyleBackColor = true;
            this.classButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(12, 290);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(187, 53);
            this.buttonMove.TabIndex = 16;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(108, 125);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(91, 49);
            this.colorButton.TabIndex = 17;
            this.colorButton.Text = "Цвет";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // thicknessTrackBar
            // 
            this.thicknessTrackBar.Location = new System.Drawing.Point(12, 349);
            this.thicknessTrackBar.Minimum = 2;
            this.thicknessTrackBar.Name = "thicknessTrackBar";
            this.thicknessTrackBar.Size = new System.Drawing.Size(187, 45);
            this.thicknessTrackBar.TabIndex = 18;
            this.thicknessTrackBar.Value = 2;
            this.thicknessTrackBar.Scroll += new System.EventHandler(this.ThicknessTrackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 505);
            this.Controls.Add(this.thicknessTrackBar);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.classButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.compositionButton);
            this.Controls.Add(this.aggregationButton);
            this.Controls.Add(this.realizationButton);
            this.Controls.Add(this.inheritanceButton);
            this.Controls.Add(this.associationButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "UML Diagram Designer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).EndInit();
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
        private System.Windows.Forms.Button classButton;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.TrackBar thicknessTrackBar;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

