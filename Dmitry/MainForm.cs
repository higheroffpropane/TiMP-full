using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using ClassLibrary1;
using System.Text.RegularExpressions;

namespace Dmitry
{
    public partial class MainForm : Form
    {
        static string myPath = "C:\\Users\\higheroffpropane\\source\\repos\\Dmitry\\dimonLog.txt";
        static DateTime lastDateTime = File.GetLastWriteTime(myPath);
        private int[] count = { 0, 0, 0, 0 };
        public MainForm()
        {
            InitializeComponent();
            StreamReader fule = new StreamReader(myPath);
            //richTextBox1.Text = fule.ReadToEnd();
            fule.Close();
        }

        private void openSecondLabButton_Click(object sender, EventArgs e)
        {
            Form newForm = new SecondLab(new MyDelegate(func));
            newForm.Show();
        }
        private void openThirdLabButton_Click(object sender, EventArgs e)
        {
            Form newForm = new ThirdLab(new MyDelegate(func));
            newForm.Show();
        }
        private void openFourthLabButton_Click(object sender, EventArgs e)
        {
            Form newForm = new FourthLab(this);
            newForm.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentDateTime = File.GetLastWriteTime(myPath);
            if (lastDateTime != currentDateTime)
            {
                lastDateTime = currentDateTime;
                updateRichBox();
            }
        }

        private void updateRichBox()
        {
            StreamReader f = new StreamReader(myPath);
            richTextBox1.Text = f.ReadToEnd();
            f.Close();
        }

        private void clearLogsButton_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter(myPath);
            f.Close();
        }

        private void SetSelectionStyle(int address, int len, FontStyle style)
        {
            richTextBox1.Select(address, len);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | style);
            richTextBox1.SelectionColor = Color.Red;
        }
        void func(string param)
        {
            richTextBox1.Text += param + "\r\n" + DateTime.Now.ToString("dd.MM.yyyy") + " " + DateTime.Now.ToLongTimeString() + "\r\n";
            Forms_Parser fp = new Forms_Parser();
            parse_result pr = fp.Parse(richTextBox1.Text);
            MatchCollection matches = pr.matches;
            richTextBox1.Text += $"\r\nВремя парсинга: {pr.time}\r\n";

            if (matches.Count > 0)
            {
                switch (matches[matches.Count - 1].Value)
                {
                    case "Form2":
                        count[0]++;
                        richTextBox1.Text += $"Исключений по 2 форме - {count[0]}\r\n\r\n";
                        break;
                    case "Form3":
                        count[1]++;
                        richTextBox1.Text += $"Исключений по 3 форме - {count[1]}\r\n\r\n";
                        break;
                    case "Form4":
                        count[2]++;
                        richTextBox1.Text += $"Исключений по 4 форме - {count[2]}\r\n\r\n";
                        break;
                    case "Form5":
                        count[3]++;
                        richTextBox1.Text += $"Исключений по 5 форме - {count[3]}\r\n\r\n";
                        break;
                }
                foreach (Match match in matches)
                {
                    SetSelectionStyle(match.Index, match.Length, FontStyle.Bold);

                }
            }
        }
        public RichTextBox GetRichTextBox()
        {
            return richTextBox1;
        }
    }
}
