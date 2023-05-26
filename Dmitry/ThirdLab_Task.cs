using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dmitry
{
    public partial class ThirdLab_Task : Form
    {
        private MyDelegate D;
        static string myPath = "C:\\Users\\higheroffpropane\\source\\repos\\Dmitry\\dimonLog.txt";
        private Bitmap image;
        private Brush brush;
        private Graphics graph;
        private Font font;

        double a1;
        double d;
        int n;
        double result;

        public ThirdLab_Task(MyDelegate sender)
        {
            InitializeComponent();
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            brush = new SolidBrush(Color.Black);
            font = new Font("Times New Roman", 16);
            D = sender;
        }
        private void ThirdLab_Task_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 0, 0);
        }
        private double termOfArifmeticProgression(double a1, double d, int n) 
        {
            if (n == 1) return a1;
            else return termOfArifmeticProgression(a1, d, n - 1) + d;
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            graph = Graphics.FromImage(image);
            graph.Clear(Color.White);
            try
            {
                a1 = Convert.ToDouble(textBoxA1.Text); 
                d = Convert.ToDouble(textBoxD.Text);
                n = Convert.ToInt32(textBoxN.Text);
                result = termOfArifmeticProgression(a1, d, n);
                string str = Convert.ToString(n) + "-й член арифметической прогрессии = " + Convert.ToString(result);

                graph.DrawString(str, font, brush, 16, 16);
                pictureBox1.Image = image;
                pictureBox1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBoxA1.BackColor = Color.Red;
                textBoxD.BackColor = Color.Red;
                textBoxN.BackColor = Color.Red;
                SendExceptionInformationInTxt(myPath, ex);
                return;
            }
            textBoxA1.BackColor = Color.Empty;
            textBoxD.BackColor = Color.Empty;
            textBoxN.BackColor = Color.Empty;
        }
        private void ThirdLab_Task_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (graph != null) graph.Dispose();
            image.Dispose();
            pictureBox1.Dispose();
        }
        private void SendExceptionInformationInTxt(string str, Exception ex)
        {
            StreamWriter f = new StreamWriter(str, true);
            f.WriteLine(DateTime.Now);
            f.WriteLine("InnerException: " + ex.InnerException + "\n");
            f.WriteLine("Message: " + ex.Message + "\n");
            f.WriteLine("Source: " + ex.Source + "\n");
            f.WriteLine("StackTrace:\n" + ex.StackTrace + "\n");
            f.WriteLine("TargetSite: " + ex.TargetSite + "\n");
            f.WriteLine("\n\n");
            f.Close();
            D($"{ex.InnerException},\n{ex.Message},\n{ex.Source},\n{ex.StackTrace},\n{ex.TargetSite}");
        }
    }
}
