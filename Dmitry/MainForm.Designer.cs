
namespace Dmitry
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openSecondLabButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clearLogsButton = new System.Windows.Forms.Button();
            this.openThirdLabButton = new System.Windows.Forms.Button();
            this.openFourthLabButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openSecondLabButton
            // 
            this.openSecondLabButton.Location = new System.Drawing.Point(12, 12);
            this.openSecondLabButton.Name = "openSecondLabButton";
            this.openSecondLabButton.Size = new System.Drawing.Size(205, 23);
            this.openSecondLabButton.TabIndex = 0;
            this.openSecondLabButton.Text = "вторая лаба";
            this.openSecondLabButton.UseVisualStyleBackColor = true;
            this.openSecondLabButton.Click += new System.EventHandler(this.openSecondLabButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 201);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clearLogsButton
            // 
            this.clearLogsButton.Location = new System.Drawing.Point(794, 41);
            this.clearLogsButton.Name = "clearLogsButton";
            this.clearLogsButton.Size = new System.Drawing.Size(75, 201);
            this.clearLogsButton.TabIndex = 2;
            this.clearLogsButton.Text = "clear logs";
            this.clearLogsButton.UseVisualStyleBackColor = true;
            this.clearLogsButton.Click += new System.EventHandler(this.clearLogsButton_Click);
            // 
            // openThirdLabButton
            // 
            this.openThirdLabButton.Location = new System.Drawing.Point(223, 12);
            this.openThirdLabButton.Name = "openThirdLabButton";
            this.openThirdLabButton.Size = new System.Drawing.Size(205, 23);
            this.openThirdLabButton.TabIndex = 3;
            this.openThirdLabButton.Text = "третья лаба";
            this.openThirdLabButton.UseVisualStyleBackColor = true;
            this.openThirdLabButton.Click += new System.EventHandler(this.openThirdLabButton_Click);
            // 
            // openFourthLabButton
            // 
            this.openFourthLabButton.Location = new System.Drawing.Point(434, 12);
            this.openFourthLabButton.Name = "openFourthLabButton";
            this.openFourthLabButton.Size = new System.Drawing.Size(205, 23);
            this.openFourthLabButton.TabIndex = 4;
            this.openFourthLabButton.Text = "четвертая лаба";
            this.openFourthLabButton.UseVisualStyleBackColor = true;
            this.openFourthLabButton.Click += new System.EventHandler(this.openFourthLabButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 468);
            this.Controls.Add(this.openFourthLabButton);
            this.Controls.Add(this.openThirdLabButton);
            this.Controls.Add(this.clearLogsButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.openSecondLabButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openSecondLabButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button clearLogsButton;
        private System.Windows.Forms.Button openThirdLabButton;
        private System.Windows.Forms.Button openFourthLabButton;
    }
}

