
namespace Dmitry
{
    partial class SecondLab
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
            this.arrayDataGridView = new System.Windows.Forms.DataGridView();
            this.fillArrayButton = new System.Windows.Forms.Button();
            this.findSumButton = new System.Windows.Forms.Button();
            this.printIndexButton = new System.Windows.Forms.Button();
            this.findSameSignNumbersButton = new System.Windows.Forms.Button();
            this.exceptionInformationLabel = new System.Windows.Forms.Label();
            this.findSumResultLabel = new System.Windows.Forms.Label();
            this.printIndexLabel = new System.Windows.Forms.Label();
            this.sameSignNumbersIndexLabel = new System.Windows.Forms.Label();
            this.fillingTimeTextBox = new System.Windows.Forms.TextBox();
            this.fillWithTimerCheckBox = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.numericUpDownShift = new System.Windows.Forms.NumericUpDown();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.exception2InformationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arrayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShift)).BeginInit();
            this.SuspendLayout();
            // 
            // arrayDataGridView
            // 
            this.arrayDataGridView.AllowUserToAddRows = false;
            this.arrayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arrayDataGridView.Location = new System.Drawing.Point(1, 53);
            this.arrayDataGridView.Name = "arrayDataGridView";
            this.arrayDataGridView.Size = new System.Drawing.Size(796, 44);
            this.arrayDataGridView.TabIndex = 0;
            // 
            // fillArrayButton
            // 
            this.fillArrayButton.Location = new System.Drawing.Point(1, 103);
            this.fillArrayButton.Name = "fillArrayButton";
            this.fillArrayButton.Size = new System.Drawing.Size(177, 23);
            this.fillArrayButton.TabIndex = 1;
            this.fillArrayButton.Text = "Заполнить массив случайно";
            this.fillArrayButton.UseVisualStyleBackColor = true;
            this.fillArrayButton.Click += new System.EventHandler(this.fillArrayButton_Click);
            // 
            // findSumButton
            // 
            this.findSumButton.Location = new System.Drawing.Point(1, 157);
            this.findSumButton.Name = "findSumButton";
            this.findSumButton.Size = new System.Drawing.Size(354, 23);
            this.findSumButton.TabIndex = 2;
            this.findSumButton.Text = "Найти удвоенную сумму положительных элементов";
            this.findSumButton.UseVisualStyleBackColor = true;
            this.findSumButton.Click += new System.EventHandler(this.findSumButton_Click);
            // 
            // printIndexButton
            // 
            this.printIndexButton.Location = new System.Drawing.Point(1, 186);
            this.printIndexButton.Name = "printIndexButton";
            this.printIndexButton.Size = new System.Drawing.Size(354, 23);
            this.printIndexButton.TabIndex = 3;
            this.printIndexButton.Text = "Вывести индексы элементов, больших предыдущих";
            this.printIndexButton.UseVisualStyleBackColor = true;
            this.printIndexButton.Click += new System.EventHandler(this.printIndexButton_Click);
            // 
            // findSameSignNumbersButton
            // 
            this.findSameSignNumbersButton.Location = new System.Drawing.Point(1, 215);
            this.findSameSignNumbersButton.Name = "findSameSignNumbersButton";
            this.findSameSignNumbersButton.Size = new System.Drawing.Size(354, 23);
            this.findSameSignNumbersButton.TabIndex = 4;
            this.findSameSignNumbersButton.Text = "Определить, есть ли соседние элементы с одинаковым знаком";
            this.findSameSignNumbersButton.UseVisualStyleBackColor = true;
            this.findSameSignNumbersButton.Click += new System.EventHandler(this.findSameSignNumbersButton_Click);
            // 
            // exceptionInformationLabel
            // 
            this.exceptionInformationLabel.AutoSize = true;
            this.exceptionInformationLabel.Location = new System.Drawing.Point(12, 342);
            this.exceptionInformationLabel.Name = "exceptionInformationLabel";
            this.exceptionInformationLabel.Size = new System.Drawing.Size(0, 13);
            this.exceptionInformationLabel.TabIndex = 5;
            // 
            // findSumResultLabel
            // 
            this.findSumResultLabel.AutoSize = true;
            this.findSumResultLabel.Location = new System.Drawing.Point(361, 162);
            this.findSumResultLabel.Name = "findSumResultLabel";
            this.findSumResultLabel.Size = new System.Drawing.Size(0, 13);
            this.findSumResultLabel.TabIndex = 6;
            // 
            // printIndexLabel
            // 
            this.printIndexLabel.AutoSize = true;
            this.printIndexLabel.Location = new System.Drawing.Point(361, 191);
            this.printIndexLabel.Name = "printIndexLabel";
            this.printIndexLabel.Size = new System.Drawing.Size(0, 13);
            this.printIndexLabel.TabIndex = 7;
            // 
            // sameSignNumbersIndexLabel
            // 
            this.sameSignNumbersIndexLabel.AutoSize = true;
            this.sameSignNumbersIndexLabel.Location = new System.Drawing.Point(361, 220);
            this.sameSignNumbersIndexLabel.Name = "sameSignNumbersIndexLabel";
            this.sameSignNumbersIndexLabel.Size = new System.Drawing.Size(0, 13);
            this.sameSignNumbersIndexLabel.TabIndex = 8;
            // 
            // fillingTimeTextBox
            // 
            this.fillingTimeTextBox.Location = new System.Drawing.Point(372, 106);
            this.fillingTimeTextBox.Name = "fillingTimeTextBox";
            this.fillingTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.fillingTimeTextBox.TabIndex = 9;
            // 
            // fillWithTimerCheckBox
            // 
            this.fillWithTimerCheckBox.AutoSize = true;
            this.fillWithTimerCheckBox.Location = new System.Drawing.Point(224, 107);
            this.fillWithTimerCheckBox.Name = "fillWithTimerCheckBox";
            this.fillWithTimerCheckBox.Size = new System.Drawing.Size(142, 17);
            this.fillWithTimerCheckBox.TabIndex = 10;
            this.fillWithTimerCheckBox.Text = "заполнить с таймером";
            this.fillWithTimerCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(563, 157);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(563, 189);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 12;
            // 
            // numericUpDownShift
            // 
            this.numericUpDownShift.Location = new System.Drawing.Point(704, 157);
            this.numericUpDownShift.Name = "numericUpDownShift";
            this.numericUpDownShift.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownShift.TabIndex = 13;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(577, 220);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonEncode.TabIndex = 14;
            this.buttonEncode.Text = "Закодировать";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(658, 220);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 15;
            this.buttonDecode.Text = "Декодировать";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // exception2InformationLabel
            // 
            this.exception2InformationLabel.AutoSize = true;
            this.exception2InformationLabel.Location = new System.Drawing.Point(560, 261);
            this.exception2InformationLabel.Name = "exception2InformationLabel";
            this.exception2InformationLabel.Size = new System.Drawing.Size(0, 13);
            this.exception2InformationLabel.TabIndex = 16;
            // 
            // SecondLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exception2InformationLabel);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.numericUpDownShift);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.fillWithTimerCheckBox);
            this.Controls.Add(this.fillingTimeTextBox);
            this.Controls.Add(this.sameSignNumbersIndexLabel);
            this.Controls.Add(this.printIndexLabel);
            this.Controls.Add(this.findSumResultLabel);
            this.Controls.Add(this.exceptionInformationLabel);
            this.Controls.Add(this.findSameSignNumbersButton);
            this.Controls.Add(this.printIndexButton);
            this.Controls.Add(this.findSumButton);
            this.Controls.Add(this.fillArrayButton);
            this.Controls.Add(this.arrayDataGridView);
            this.Name = "SecondLab";
            this.Text = "SecondLab";
            ((System.ComponentModel.ISupportInitialize)(this.arrayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView arrayDataGridView;
        private System.Windows.Forms.Button fillArrayButton;
        private System.Windows.Forms.Button findSumButton;
        private System.Windows.Forms.Button printIndexButton;
        private System.Windows.Forms.Button findSameSignNumbersButton;
        private System.Windows.Forms.Label exceptionInformationLabel;
        private System.Windows.Forms.Label findSumResultLabel;
        private System.Windows.Forms.Label printIndexLabel;
        private System.Windows.Forms.Label sameSignNumbersIndexLabel;
        private System.Windows.Forms.TextBox fillingTimeTextBox;
        private System.Windows.Forms.CheckBox fillWithTimerCheckBox;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.NumericUpDown numericUpDownShift;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Label exception2InformationLabel;
    }
}