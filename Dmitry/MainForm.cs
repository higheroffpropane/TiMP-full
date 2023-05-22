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

namespace Dmitry
{
    public partial class MainForm : Form
    {
        static string myPath = "C:\\Users\\higheroffpropane\\source\\repos\\Dmitry\\dimonLog.txt";
        static DateTime lastDateTime = File.GetLastWriteTime(myPath);
        public MainForm()
        {
            InitializeComponent();
            StreamReader fule = new StreamReader(myPath);
            richTextBox1.Text = fule.ReadToEnd();
            fule.Close();
        }

        private void openSecondLabButton_Click(object sender, EventArgs e)
        {
            Form newForm = new SecondLab();
            newForm.Show();
        }
        private void openThirdLabButton_Click(object sender, EventArgs e)
        {
            Form newForm = new ThirdLab();
            newForm.Show();
        }
        private void openFourthLabButton_Click(object sender, EventArgs e)
        {
            Form newForm = new FourthLab();
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


    }
}
