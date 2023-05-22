using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Dmitry
{
    public partial class FourthLab : Form
    {
        MainForm mainForm;
        public string s;
        public MatchCollection myMatch;
        public string signature;

        public FourthLab()
        {
            InitializeComponent();
        }
        public FourthLab (MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            string filetext = System.IO.File.ReadAllText(filename);
            richTextBox1.Text = filetext;

/*            s = richTextBox1.Text;
            signature = comboBox1.Text;

            //

            Regex regex = new Regex(signature);
            MatchCollection matches = regex.Matches(s);
            myMatch = matches;
            textBox1 .Text = "Все вхождения " + signature + " в исходном тексте:" + "\r\n";
            if (matches.Count > 0)
                foreach (Match match in matches)
                    textBox1.Text += match.Index + "-ая позиция" + "\t" + match.Value + "\r\n";
            else textBox1.Text = "Совадений нет";*/
        }
        private void SetSelectionStyle(int startIndex, int length, FontStyle style)
        {
            richTextBox1.Select(startIndex, length);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | style);
            richTextBox1.SelectionColor = System.Drawing.Color.Red;
        }
        private void markButton_Click(object sender, EventArgs e)
        {
            foreach (Match m in myMatch)
            {
                SetSelectionStyle(m.Index, m.Length, FontStyle.Underline);
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            s = richTextBox1.Text;
            signature = comboBox1.Text;

            //

            Regex regex = new Regex(signature);
            MatchCollection matches = regex.Matches(s);
            myMatch = matches;
            textBox1.Text = "Все вхождения " + signature + " в исходном тексте:" + "\r\n";
            if (matches.Count > 0)
                foreach (Match match in matches)
                    textBox1.Text += match.Index + "-ая позиция" + "\t" + match.Value + "\r\n";
            else textBox1.Text = "Совадений нет";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            findButton_Click(sender, e);
            //markButton_Click(sender, e);
        }
    }
}
