namespace Dmitry
{
    partial class ThirdLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThirdLab));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.buttonResize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFourier = new System.Windows.Forms.Button();
            this.radioButtonStr = new System.Windows.Forms.RadioButton();
            this.radioButtonTri = new System.Windows.Forms.RadioButton();
            this.radioButtonSaw = new System.Windows.Forms.RadioButton();
            this.numericUpDownFreq = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRange = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHarm = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.labelColor = new System.Windows.Forms.Label();
            this.numericUpDownPenWidth = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonPen = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonTask = new System.Windows.Forms.Button();
            this.buttonFractals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHarm)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPenWidth)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 268);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThirdLab_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThirdLab_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThirdLab_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(256, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.newToolStripMenuItem.Text = "новый";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.openToolStripMenuItem.Text = "открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.saveToolStripMenuItem.Text = "сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exitToolStripMenuItem.Text = "выйти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownHeight.Location = new System.Drawing.Point(34, 40);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHeight.TabIndex = 3;
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownWidth.Location = new System.Drawing.Point(34, 66);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWidth.TabIndex = 4;
            // 
            // buttonResize
            // 
            this.buttonResize.Location = new System.Drawing.Point(34, 92);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(75, 23);
            this.buttonResize.TabIndex = 5;
            this.buttonResize.Text = "resize";
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonFourier);
            this.panel1.Controls.Add(this.radioButtonStr);
            this.panel1.Controls.Add(this.radioButtonTri);
            this.panel1.Controls.Add(this.radioButtonSaw);
            this.panel1.Controls.Add(this.numericUpDownFreq);
            this.panel1.Controls.Add(this.numericUpDownRange);
            this.panel1.Controls.Add(this.numericUpDownHarm);
            this.panel1.Location = new System.Drawing.Point(7, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 117);
            this.panel1.TabIndex = 6;
            // 
            // buttonFourier
            // 
            this.buttonFourier.Location = new System.Drawing.Point(49, 81);
            this.buttonFourier.Name = "buttonFourier";
            this.buttonFourier.Size = new System.Drawing.Size(75, 23);
            this.buttonFourier.TabIndex = 9;
            this.buttonFourier.Text = "draw";
            this.buttonFourier.UseVisualStyleBackColor = true;
            this.buttonFourier.Click += new System.EventHandler(this.buttonFourier_Click);
            // 
            // radioButtonStr
            // 
            this.radioButtonStr.AutoSize = true;
            this.radioButtonStr.Checked = true;
            this.radioButtonStr.Location = new System.Drawing.Point(104, 6);
            this.radioButtonStr.Name = "radioButtonStr";
            this.radioButtonStr.Size = new System.Drawing.Size(59, 17);
            this.radioButtonStr.TabIndex = 16;
            this.radioButtonStr.TabStop = true;
            this.radioButtonStr.Text = "straight";
            this.radioButtonStr.UseVisualStyleBackColor = true;
            this.radioButtonStr.CheckedChanged += new System.EventHandler(this.radioButtonStr_CheckedChanged);
            // 
            // radioButtonTri
            // 
            this.radioButtonTri.AutoSize = true;
            this.radioButtonTri.Location = new System.Drawing.Point(104, 32);
            this.radioButtonTri.Name = "radioButtonTri";
            this.radioButtonTri.Size = new System.Drawing.Size(68, 17);
            this.radioButtonTri.TabIndex = 15;
            this.radioButtonTri.TabStop = true;
            this.radioButtonTri.Text = "triangular";
            this.radioButtonTri.UseVisualStyleBackColor = true;
            this.radioButtonTri.CheckedChanged += new System.EventHandler(this.radioButtonTri_CheckedChanged);
            // 
            // radioButtonSaw
            // 
            this.radioButtonSaw.AutoSize = true;
            this.radioButtonSaw.Location = new System.Drawing.Point(104, 58);
            this.radioButtonSaw.Name = "radioButtonSaw";
            this.radioButtonSaw.Size = new System.Drawing.Size(68, 17);
            this.radioButtonSaw.TabIndex = 14;
            this.radioButtonSaw.TabStop = true;
            this.radioButtonSaw.Text = "sawtooth";
            this.radioButtonSaw.UseVisualStyleBackColor = true;
            this.radioButtonSaw.CheckedChanged += new System.EventHandler(this.radioButtonSaw_CheckedChanged);
            // 
            // numericUpDownFreq
            // 
            this.numericUpDownFreq.Location = new System.Drawing.Point(5, 55);
            this.numericUpDownFreq.Name = "numericUpDownFreq";
            this.numericUpDownFreq.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownFreq.TabIndex = 13;
            this.numericUpDownFreq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFreq.ValueChanged += new System.EventHandler(this.numericUpDownFreq_ValueChanged);
            // 
            // numericUpDownRange
            // 
            this.numericUpDownRange.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRange.Location = new System.Drawing.Point(5, 29);
            this.numericUpDownRange.Name = "numericUpDownRange";
            this.numericUpDownRange.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownRange.TabIndex = 12;
            this.numericUpDownRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRange.ValueChanged += new System.EventHandler(this.numericUpDownRange_ValueChanged);
            // 
            // numericUpDownHarm
            // 
            this.numericUpDownHarm.Location = new System.Drawing.Point(5, 3);
            this.numericUpDownHarm.Name = "numericUpDownHarm";
            this.numericUpDownHarm.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownHarm.TabIndex = 11;
            this.numericUpDownHarm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHarm.ValueChanged += new System.EventHandler(this.numericUpDownHarm_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonFill);
            this.panel2.Controls.Add(this.labelColor);
            this.panel2.Controls.Add(this.numericUpDownPenWidth);
            this.panel2.Location = new System.Drawing.Point(7, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 79);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonFill
            // 
            this.buttonFill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFill.Location = new System.Drawing.Point(14, 39);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(75, 23);
            this.buttonFill.TabIndex = 9;
            this.buttonFill.Text = "fill";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // labelColor
            // 
            this.labelColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.Color.Black;
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColor.Location = new System.Drawing.Point(140, 15);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(18, 15);
            this.labelColor.TabIndex = 9;
            this.labelColor.Text = "   ";
            this.labelColor.Click += new System.EventHandler(this.labelColor_Click);
            // 
            // numericUpDownPenWidth
            // 
            this.numericUpDownPenWidth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownPenWidth.Location = new System.Drawing.Point(14, 13);
            this.numericUpDownPenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPenWidth.Name = "numericUpDownPenWidth";
            this.numericUpDownPenWidth.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPenWidth.TabIndex = 9;
            this.numericUpDownPenWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPenWidth.ValueChanged += new System.EventHandler(this.numericUpDownPenWidth_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonLine);
            this.panel3.Controls.Add(this.radioButtonPen);
            this.panel3.Location = new System.Drawing.Point(7, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 60);
            this.panel3.TabIndex = 8;
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(14, 29);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(41, 17);
            this.radioButtonLine.TabIndex = 1;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = "line";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            this.radioButtonLine.CheckedChanged += new System.EventHandler(this.radioButtonLine_CheckedChanged);
            // 
            // radioButtonPen
            // 
            this.radioButtonPen.AutoSize = true;
            this.radioButtonPen.Checked = true;
            this.radioButtonPen.Location = new System.Drawing.Point(14, 6);
            this.radioButtonPen.Name = "radioButtonPen";
            this.radioButtonPen.Size = new System.Drawing.Size(43, 17);
            this.radioButtonPen.TabIndex = 0;
            this.radioButtonPen.TabStop = true;
            this.radioButtonPen.Text = "pen";
            this.radioButtonPen.UseVisualStyleBackColor = true;
            this.radioButtonPen.CheckedChanged += new System.EventHandler(this.radioButtonPen_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonTask);
            this.panel4.Controls.Add(this.buttonFractals);
            this.panel4.Location = new System.Drawing.Point(209, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 75);
            this.panel4.TabIndex = 9;
            // 
            // buttonTask
            // 
            this.buttonTask.Location = new System.Drawing.Point(104, 3);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(93, 69);
            this.buttonTask.TabIndex = 1;
            this.buttonTask.Text = "task";
            this.buttonTask.UseVisualStyleBackColor = true;
            this.buttonTask.Click += new System.EventHandler(this.buttonTask_Click);
            // 
            // buttonFractals
            // 
            this.buttonFractals.Location = new System.Drawing.Point(3, 3);
            this.buttonFractals.Name = "buttonFractals";
            this.buttonFractals.Size = new System.Drawing.Size(93, 69);
            this.buttonFractals.TabIndex = 0;
            this.buttonFractals.Text = "fractals";
            this.buttonFractals.UseVisualStyleBackColor = true;
            this.buttonFractals.Click += new System.EventHandler(this.buttonFractals_Click);
            // 
            // ThirdLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonResize);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ThirdLab";
            this.Text = "ThirdLab";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThirdLab_FormClosing);
            this.Load += new System.EventHandler(this.ThirdLab_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ThirdLab_Paint);
            this.Resize += new System.EventHandler(this.ThirdLab_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHarm)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPenWidth)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFourier;
        private System.Windows.Forms.RadioButton radioButtonStr;
        private System.Windows.Forms.RadioButton radioButtonTri;
        private System.Windows.Forms.RadioButton radioButtonSaw;
        private System.Windows.Forms.NumericUpDown numericUpDownFreq;
        private System.Windows.Forms.NumericUpDown numericUpDownRange;
        private System.Windows.Forms.NumericUpDown numericUpDownHarm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.NumericUpDown numericUpDownPenWidth;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.RadioButton radioButtonPen;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonTask;
        private System.Windows.Forms.Button buttonFractals;
        private System.Windows.Forms.Button button1;
    }
}