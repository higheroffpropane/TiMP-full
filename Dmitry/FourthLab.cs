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
using System.IO;

namespace Dmitry
{
    public partial class FourthLab : Form
    {
        static string myPath = "C:\\Users\\higheroffpropane\\source\\repos\\Dmitry\\dimonLog.txt";
        MainForm mainForm;
        public string s;
        public MatchCollection myMatch;
        public string signature;
        Regex regex;
        Color[] colors = { Color.Red, Color.Orange, Color.Gold, Color.Green, Color.Blue, Color.Purple };


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
        private void SetSelectionStyle1(int address, int len, FontStyle style, Color select_color, RichTextBox source)
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
                SetSelectionStyle1(match.Index, match.Length, FontStyle.Bold, clr, richTextBox1);
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

        private async void button3_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter(myPath);

            RichTextBox form1_textbox = mainForm.GetRichTextBox();
            string form1_txt = form1_textbox.Text;

            Time_Parser tp = new Time_Parser();
            Parser formP = new Parser();
            Parse_Result time_result = tp.Parse(form1_txt), form_result = formP.Parse(form1_txt);

/*            Parse_Result time_result = new Parse_Result();
            Parse_Result form_result = new Parse_Result();
            await T_parsing(time_result);
            await F_parsing(form_result);*/

            MatchCollection time_matches = time_result.matches;
            MatchCollection form_matches = form_result.matches;
            foreach (Match form_match in form_matches)
            {
                int ex_num;
                for (ex_num = 0; time_matches[ex_num].Index < form_match.Index; ex_num++) ;
                TimeSpan ex_time = TimeSpan.Parse(time_matches[ex_num].Value);

                if (dateTimePicker1.Value.TimeOfDay <= ex_time && dateTimePicker2.Value.TimeOfDay >= ex_time)
                {
                    //form1_textbox.Text = form1_txt.Insert(form_match.Index + form_match.Value.Length, "(5.18.146.97)");
                    //f.Write(form1_textbox.Text);
                    SetSelectionStyle1(form_match.Index, form_match.Value.Length, FontStyle.Bold, Color.Green, form1_textbox);
                    
                }
                else
                {
                    SetSelectionStyle1(form_match.Index, form_match.Value.Length, FontStyle.Bold, Color.Blue, form1_textbox);
                }
            }
            textBox1.Text = $"Время парсинга времени: {time_result.time}\r\nВремя парсинга Lab: {form_result.time}";
            f.Close();
        }
/*        async Task T_parsing(Parse_Result T_result)
        {
            RichTextBox form1_textbox = mainForm.GetRichTextBox();
            string form1_txt = form1_textbox.Text;
            Time_Parser tp = new Time_Parser();
            T_result = tp.Parse(form1_txt);
        }
        async Task F_parsing(Parse_Result F_result)
        {
            RichTextBox form1_textbox = mainForm.GetRichTextBox();
            string form1_txt = form1_textbox.Text;
            Parser fp = new Parser();
            F_result = fp.Parse(form1_txt);
        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"\d{2}\:\d{2}\:\d{2}\n");
            RichTextBox form1_textbox = mainForm.GetRichTextBox();
            MatchCollection matches = regex.Matches(form1_textbox.Text);
            int shift = 0;
            foreach (Match match in matches)
            {
                DateTime date = DateTime.Parse(match.Value);
                if (date >= DateTime.Parse("20:35:00") && date <= DateTime.Parse("21:00:00"))
                {
                    SetSelectionStyle1(match.Index, match.Value.Length, FontStyle.Bold, Color.Green, form1_textbox);
                }
                else
                {
                    SetSelectionStyle1(match.Index, match.Value.Length, FontStyle.Bold, Color.Blue, form1_textbox);
                }
            }
        }
    }
}
