namespace Dmitry
{
    partial class ThirdLab_Fractals
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonTree = new System.Windows.Forms.Button();
            this.numericUpDownTree = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxTree = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxSerp = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonSerp = new System.Windows.Forms.Button();
            this.numericUpDownSerp = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTree)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSerp)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonTree);
            this.panel4.Controls.Add(this.numericUpDownTree);
            this.panel4.Location = new System.Drawing.Point(3, 363);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 84);
            this.panel4.TabIndex = 1;
            // 
            // buttonTree
            // 
            this.buttonTree.Location = new System.Drawing.Point(313, 3);
            this.buttonTree.Name = "buttonTree";
            this.buttonTree.Size = new System.Drawing.Size(75, 23);
            this.buttonTree.TabIndex = 2;
            this.buttonTree.Text = "дерево";
            this.buttonTree.UseVisualStyleBackColor = true;
            this.buttonTree.Visible = false;
            this.buttonTree.Click += new System.EventHandler(this.buttonTree_Click);
            // 
            // numericUpDownTree
            // 
            this.numericUpDownTree.Location = new System.Drawing.Point(0, 3);
            this.numericUpDownTree.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownTree.Name = "numericUpDownTree";
            this.numericUpDownTree.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTree.TabIndex = 0;
            this.numericUpDownTree.ValueChanged += new System.EventHandler(this.numericUpDownTree_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxTree);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 354);
            this.panel2.TabIndex = 0;
            // 
            // pictureBoxTree
            // 
            this.pictureBoxTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTree.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTree.Name = "pictureBoxTree";
            this.pictureBoxTree.Size = new System.Drawing.Size(391, 354);
            this.pictureBoxTree.TabIndex = 0;
            this.pictureBoxTree.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(403, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(397, 450);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBoxSerp);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 354);
            this.panel3.TabIndex = 1;
            // 
            // pictureBoxSerp
            // 
            this.pictureBoxSerp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSerp.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSerp.Name = "pictureBoxSerp";
            this.pictureBoxSerp.Size = new System.Drawing.Size(391, 354);
            this.pictureBoxSerp.TabIndex = 1;
            this.pictureBoxSerp.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonSerp);
            this.panel5.Controls.Add(this.numericUpDownSerp);
            this.panel5.Location = new System.Drawing.Point(3, 363);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(391, 84);
            this.panel5.TabIndex = 2;
            // 
            // buttonSerp
            // 
            this.buttonSerp.Location = new System.Drawing.Point(313, 3);
            this.buttonSerp.Name = "buttonSerp";
            this.buttonSerp.Size = new System.Drawing.Size(75, 23);
            this.buttonSerp.TabIndex = 3;
            this.buttonSerp.Text = "салфетка";
            this.buttonSerp.UseVisualStyleBackColor = true;
            this.buttonSerp.Visible = false;
            this.buttonSerp.Click += new System.EventHandler(this.buttonSerp_Click);
            // 
            // numericUpDownSerp
            // 
            this.numericUpDownSerp.Location = new System.Drawing.Point(3, 3);
            this.numericUpDownSerp.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSerp.Name = "numericUpDownSerp";
            this.numericUpDownSerp.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSerp.TabIndex = 1;
            this.numericUpDownSerp.ValueChanged += new System.EventHandler(this.numericUpDownSerp_ValueChanged);
            // 
            // ThirdLab_Fractals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ThirdLab_Fractals";
            this.Text = "ThirdLab_Fractals";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTree)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSerp)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericUpDownTree;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown numericUpDownSerp;
        private System.Windows.Forms.PictureBox pictureBoxTree;
        private System.Windows.Forms.PictureBox pictureBoxSerp;
        private System.Windows.Forms.Button buttonTree;
        private System.Windows.Forms.Button buttonSerp;
    }
}