using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dmitry
{
    public partial class ThirdLab_Fractals : Form
    {
        int flag = 0;
        static string myPath = "C:\\Users\\higheroffpropane\\source\\repos\\Dmitry\\dimonLog.txt";
        public ThirdLab_Fractals()
        {
            InitializeComponent();
            this.Resize += Lab3_Resize;
        }
        private void Lab3_Resize(object sender, EventArgs e)
        {
            pictureBoxTree.Refresh();
            pictureBoxSerp.Refresh();

            buttonTree_Click(sender, e);
            buttonSerp_Click(sender, e);
        }
        private void numericUpDownTree_ValueChanged(object sender, EventArgs e)
        {
            buttonTree_Click(sender, e);
        }
        private void numericUpDownSerp_ValueChanged(object sender, EventArgs e)
        {
            buttonSerp_Click(sender, e);
        }
        private void buttonTree_Click(object sender, EventArgs e)
        {
            int temp = (int)numericUpDownTree.Value;
            int green = 0;
            int inc = 0;
            try
            {
                inc = 255 / temp;
            }
            catch (DivideByZeroException ex)
            {
                SendExceptionInformationInTxt(myPath, ex);
            }
            finally
            {
                pictureBoxTree.Refresh();
            }

            Graphics g = pictureBoxTree.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(102, green, 0));
            float temp2 = pictureBoxTree.Width / 98;

            double lineLength;
            if (pictureBoxTree.Height <= pictureBoxTree.Width) lineLength = pictureBoxTree.Height / 3;
            else lineLength = pictureBoxTree.Width / 3;

            drawTree(pictureBoxTree.Width / 2, pictureBoxTree.Height - pictureBoxTree.Height / 10, Math.PI / 2, lineLength, temp, g, pen, inc, green - inc, temp2 / (float)0.6);

            g.Dispose();
        }
        public void drawTree(double x0, double y0, double a, double lineLength, int n, Graphics g, Pen pen, int increment, int green, float penWidth)
        {
            const double k = 0.7;
            double x1, y1;

            if (n > 0)
            {
                x1 = x0 + lineLength * Math.Cos(a);
                y1 = y0 - lineLength * Math.Sin(a);

                green += increment;
                pen.Color = Color.FromArgb(102, green, 0);
                penWidth *= (float)k;
                pen.Width = penWidth;

                g.DrawLine(pen, (float)x0, (float)y0, (float)x1, (float)y1);


                drawTree(x1, y1, a + Math.PI / 4, lineLength * 0.6, n - 1, g, pen, increment, green, penWidth);
                drawTree(x1, y1, a - Math.PI / 4, lineLength * 0.6, n - 1, g, pen, increment, green, penWidth);
            }
        }
        async private void buttonSerp_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDownSerp.Value;
            int inc = 0;
            try
            {
                inc = 255 / n;
            }
            catch (DivideByZeroException ex)
            {
                SendExceptionInformationInTxt(myPath, ex);
            }
            finally
            {
                pictureBoxSerp.Refresh();
            }

            int colorGreen = 0;
            int colorBlue = 0;
            double qSize;

            Graphics g = pictureBoxSerp.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            float penWidth = pen.Width = 4;


            if (pictureBoxSerp.Height <= pictureBoxSerp.Width) qSize = pictureBoxSerp.Height / 2;
            else qSize = pictureBoxSerp.Width / 2;

            await drawSerp(pictureBoxSerp.Width / 2 - (qSize / 2), pictureBoxSerp.Height / 2 - (qSize / 2), qSize, n, g, colorGreen, colorBlue, inc, penWidth / (float)0.5);

            g.Dispose();
        }

        async private Task drawSerp(double x0, double y0, double size, int n, Graphics g, int colorGreen, int colorBlue, int increment, float penWidth)
        {
            const double k = 0.5;


            if (n > 0)
            {
                penWidth *= (float)k;
                colorGreen += increment;
                colorBlue += increment;

                SolidBrush brush = new SolidBrush(Color.FromArgb(0, colorGreen, colorBlue));
                g.FillRectangle(brush, (float)x0 + (float)k * penWidth, (float)y0 + (float)k * penWidth, (float)size - penWidth, (float)size - penWidth);

                await drawSerp((float)x0 - (size * k / 2), (float)y0 - (size * k / 2), size * k, n - 1, g, colorGreen, colorBlue, increment, penWidth); //left up
                await drawSerp((float)x0 - (size * k / 2), (float)y0 + size - (size * k / 2), size * k, n - 1, g, colorGreen, colorBlue, increment, penWidth); //left down
                await drawSerp((float)x0 + size - (size * k / 2), (float)y0 - (size * k / 2), size * k, n - 1, g, colorGreen, colorBlue, increment, penWidth); //right up
                await drawSerp((float)x0 + size - (size * k / 2), (float)y0 + size - (size * k / 2), size * k, n - 1, g, colorGreen, colorBlue, increment, penWidth); //right down

            }
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
        }
    }
}
