using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;


namespace Dmitry
{
    public partial class ThirdLab : Form
    {
        static string myPath = "C:\\Users\\higheroffpropane\\source\\repos\\Dmitry\\dimonLog.txt";
        private Bitmap image;

        private Point lastPoint;
        private Point start_point;
        private Point move_point;

        private Pen pen;
        private Pen pen2;

        private int mode = 0;
        private int modeFourier = 0;
        private int flag = 0;

        private Brush brush;
        private bool isDrawing;
        Graphics gr;

        int A = 1;
        int F = 1;
        int nterms = 1;

        public ThirdLab()
        {
            InitializeComponent();
            numericUpDownWidth.Value = pictureBox1.Width;
            numericUpDownHeight.Value = pictureBox1.Height;
            image = new Bitmap(Convert.ToInt32(numericUpDownWidth.Value), Convert.ToInt32(numericUpDownHeight.Value));
            pen = new Pen(Color.Black, 1);
            pen.EndCap = pen.StartCap = LineCap.Round;
            brush = new SolidBrush(Color.Black);
            isDrawing = false;

            pen2 = new Pen(Color.Black, 1);
        }
        private void ThirdLab_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = image;
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void ThirdLab_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 209, 121);
        }
        private void radioButtonPen_CheckedChanged(object sender, EventArgs e)
        {
            mode = 0;
            flag = 0;
        }

        private void radioButtonLine_CheckedChanged(object sender, EventArgs e)
        {
            mode = 1;
            flag = 0;
        }
        private void ThirdLab_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                move_point = start_point = e.Location;
                lastPoint = e.Location;
                isDrawing = true;
            }
        }

        private void ThirdLab_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                switch (mode)
                {
                    case 0:
                        gr = Graphics.FromImage(image);
                        gr.SmoothingMode = SmoothingMode.AntiAlias;
                        gr.DrawLine(pen, lastPoint, e.Location);
                        lastPoint = e.Location;
                        pictureBox1.Image = image;
                        break;
                    case 1:
                        Graphics g_ = pictureBox1.CreateGraphics();
                        pictureBox1.Refresh();
                        g_.DrawLine(pen, start_point, move_point);
                        move_point = e.Location;
                        g_.DrawLine(pen, start_point, move_point);
                        g_.Dispose();
                        break;
                }
            }
        }

        private void ThirdLab_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                switch (mode)
                {
                    case 0:
                        this.Invalidate();
                        break;
                    case 1:
                        g.DrawLine(pen, lastPoint, e.Location);
                        this.Invalidate();
                        break;
                }

                g.Dispose();
                pictureBox1.Image = new Bitmap(pictureBox1.Image);
                pictureBox1.Invalidate();
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = new Bitmap(ClientSize.Width, ClientSize.Height);
            pictureBox1.Image = image;
            pictureBox1.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Bitmap Files (*.bmp)|*.bmp|JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        image = new Bitmap(openFileDialog.FileName);
                        pictureBox1.Image = image;
                        pictureBox1.Invalidate();
                    }
                }
            }
            catch (Exception ex)
            {
                SendExceptionInformationInTxt(myPath, ex);
                return;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Bitmap Files (*.bmp)|*.bmp|JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        image.Save(saveFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                SendExceptionInformationInTxt(myPath, ex);
                return;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDownPenWidth_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = Convert.ToInt32(numericUpDownPenWidth.Value);
            if (flag == 1)
                redrawFourier();
        }

        private void labelColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    labelColor.BackColor = colorDialog.Color;
                    pen.Color = colorDialog.Color;
                    brush = new SolidBrush(colorDialog.Color);
                }
            }
            if (flag == 1)
                redrawFourier();
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            gr = Graphics.FromImage(image);
            gr.Clear(pen.Color);
            pictureBox1.Image = image;
            gr.Dispose();
            pictureBox1.Invalidate();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            gr = Graphics.FromImage(image);
            gr.Clear(Color.White);
            pictureBox1.Image = image;
            gr.Dispose();
            pictureBox1.Invalidate();
        }
        private void ThirdLab_Resize(object sender, EventArgs e)
        {
/*          image = new Bitmap(ClientSize.Width, ClientSize.Height);
            pictureBox1.Invalidate();*/
        }
        private void buttonResize_Click(object sender, EventArgs e)
        {
            image = new Bitmap(Convert.ToInt32(numericUpDownWidth.Value), Convert.ToInt32(numericUpDownHeight.Value));
            pictureBox1.Width = Convert.ToInt32(numericUpDownWidth.Value);
            pictureBox1.Height = Convert.ToInt32(numericUpDownHeight.Value);
            if (flag == 1)
                redrawFourier();
            pictureBox1.Image = image;
            pictureBox1.Invalidate();

        }

        private void ThirdLab_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gr != null)
                gr.Dispose();
            image.Dispose();
        }

        private void redrawFourier()
        {
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }
            flag = 1;

            gr = Graphics.FromImage(image);
            gr.Clear(Color.White);

            gr.DrawLine(pen2, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            int Interval = pictureBox1.Width;


            double yp = 0, yy1 = 0, yy2 = 0;
            int angle = 0;

            int xtemp = 0;
            int ytemp = pictureBox1.Height / 2;

            for (int i = 0; i < Interval; i++)
            {
                for (int j = 1; j <= nterms; j++)
                {
                    switch (modeFourier)
                    {

                        case 0:
                            yy1 = A / (j * 2 - 1);
                            double arg = (j * 2 - 1) * F * 0.01397 * angle;
                            yy2 = Math.Sin(arg);
                            yp = yp + yy1 * yy2;
                            break;

                        case 1:
                            yy1 = A / j;
                            double arg1 = j * F * 0.01397 * angle;
                            yy2 = Math.Sin(arg1);
                            yp = yp + yy1 * yy2;
                            break;

                        case 2:
                            yy1 = A / ((2 * j - 1) * (2 * j - 1));
                            double arg2 = (2 * j - 1) * F * 0.01397 * angle;
                            yy2 = Math.Cos(arg2);
                            yp = yp + yy1 * yy2;
                            break;
                    }
                }
                gr.DrawLine(pen,xtemp,ytemp,i,pictureBox1.Height / 2 + (int)Math.Truncate(yp));
                xtemp = i;
                ytemp = pictureBox1.Height / 2 + (int)Math.Truncate(yp);
                yp = 0;
                angle += 1;
            }
            gr.Dispose();
            pictureBox1.Invalidate();
        }
        private void radioButtonStr_CheckedChanged(object sender, EventArgs e)
        {
            modeFourier = 0;
        }
        private void radioButtonTri_CheckedChanged(object sender, EventArgs e)
        {
            modeFourier = 1;
        }
        private void radioButtonSaw_CheckedChanged(object sender, EventArgs e)
        {
            modeFourier = 2;
        }
        private void numericUpDownHarm_ValueChanged(object sender, EventArgs e)
        {
            nterms = Convert.ToInt32(numericUpDownHarm.Value);
            buttonFourier_Click(sender, e);
        }

        private void numericUpDownRange_ValueChanged(object sender, EventArgs e)
        {
            A = Convert.ToInt32(numericUpDownRange.Value);
            buttonFourier_Click(sender, e);
        }

        private void numericUpDownFreq_ValueChanged(object sender, EventArgs e)
        {
            F = Convert.ToInt32(numericUpDownFreq.Value);
            buttonFourier_Click(sender, e);
        }
        private void buttonFourier_Click(object sender, EventArgs e)
        {
            buttonClear_Click(sender, e);
            redrawFourier();
        }


        private void buttonFractals_Click(object sender, EventArgs e)
        {
            Form newForm = new ThirdLab_Fractals();
            newForm.Show();
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            Form newForm = new ThirdLab_Task();
            newForm.Show();
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