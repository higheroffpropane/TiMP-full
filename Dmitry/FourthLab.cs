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
using System.Runtime.InteropServices;
using ClassLibrary1;

namespace Dmitry
{
    public partial class FourthLab : Form
    {
        MainForm mainForm;
        public string s;
        public MatchCollection myMatch;
        public string signature;
        Regex regex;
        Color[] colors = { Color.Red, Color.Orange, Color.Gold, Color.Green, Color.Blue, Color.Purple };

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
        }
        private void SetSelectionStyle(int address, int len, FontStyle style, Color select_color, RichTextBox source)
        {
            source.Select(address, len);
            source.SelectionFont = new Font(source.SelectionFont, source.SelectionFont.Style | style);
            source.SelectionColor = select_color;
/*            source.DeselectAll();*/
        }
        private void markButton_Click(object sender, EventArgs e)
        {
            foreach (Match match in myMatch)
            {
                Color clr = colors[comboBox1.SelectedIndex];
                SetSelectionStyle(match.Index, match.Length, FontStyle.Bold, clr, richTextBox1);
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            s = richTextBox1.Text;
            signature = "(?i)" + comboBox1.Text;
            regex = new Regex(@signature);
            myMatch = regex.Matches(s);
            if (myMatch.Count > 0)
            {
                foreach (Match match in myMatch)
                {
                    textBox1.Text += $"{match.Index} - {match.Value}\r\n";
                }
            }
            else
            {
                textBox1.Text = "Совпадений не найдено";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            findButton_Click(sender, e);
            //markButton_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RichTextBox form1_textbox = mainForm.GetRichTextBox();
            string form1_txt = form1_textbox.Text;

            Time_Parser tp = new Time_Parser();
            dataGridView_Parser DGVp = new dataGridView_Parser();
            parse_result time_result = tp.Parse(form1_txt),
                         DGV_result = DGVp.Parse(form1_txt);

            MatchCollection time_matches = time_result.matches;
            MatchCollection DGV_matches = DGV_result.matches;
            textBox1.Text = $"Время парсинга времени: {time_result.time}\r\nВремя парсинга dataGridView: {DGV_result.time}";
            foreach (Match DGV_match in DGV_matches)
            {
                int ex_num;
                for (ex_num = 0; time_matches[ex_num].Index < DGV_match.Index; ex_num++) ;
                TimeSpan ex_time = TimeSpan.Parse(time_matches[ex_num].Value);
                if (dateTimePicker1.Value.TimeOfDay <= ex_time && dateTimePicker2.Value.TimeOfDay >= ex_time)
                {
                    SetSelectionStyle(DGV_match.Index, DGV_match.Value.Length, FontStyle.Bold, Color.Green, form1_textbox);
                }
                else
                {
                    SetSelectionStyle(DGV_match.Index, DGV_match.Value.Length, FontStyle.Bold, Color.Blue, form1_textbox);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"\d{2}\.\d{2}\.\d{4}");
            RichTextBox form1_textbox = mainForm.GetRichTextBox();
            MatchCollection matches = regex.Matches(form1_textbox.Text);
            int shift = 0;
            foreach (Match match in matches)
            {
                DateTime date = DateTime.Parse(match.Value);
                if (date >= DateTime.Parse("24.11.2022") && date <= DateTime.Parse("24.11.2023"))
                {
                    form1_textbox.Text = form1_textbox.Text.Insert(match.Index + shift + match.Length, " error ");
                    shift += 7;
                }
            }
            shift = 0;
            foreach (Match match in matches)
            {
                DateTime date = DateTime.Parse(match.Value);
                if (date >= DateTime.Parse("24.11.2022") && date <= DateTime.Parse("05.12.2022"))
                {
                    SetSelectionStyle(match.Index + shift, match.Value.Length + 7, FontStyle.Bold, Color.Red, form1_textbox);
                    shift += 7;
                }
            }
        }
    }
}
