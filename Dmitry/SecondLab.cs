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

namespace Dmitry
{
    public partial class SecondLab : Form
    {
        static string myPath = "C:\\Users\\higheroffpropane\\source\\repos\\Dmitry\\dimonLog.txt";
        public SecondLab()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                arrayDataGridView.Columns.Add("", Convert.ToString(i));
                arrayDataGridView.Columns[i].Width = 75;
            }
            arrayDataGridView.Rows.Add();
        }

        private void fillArrayButton_Click(object sender, EventArgs e)
        {
            exceptionInformationLabel.Text = "";
            int timerCoolDown = 0;
            if (fillWithTimerCheckBox.Checked)
            {
                try
                {
                    timerCoolDown = Convert.ToInt32(fillingTimeTextBox.Text);
                    if (timerCoolDown < 0) throw new Exception("Время отрицательное");
                    fillingTimeTextBox.BackColor = Color.Empty;
                    fillingTimeTextBox.Refresh();
                }
                catch (Exception ex)
                {
                    fillingTimeTextBox.BackColor = Color.Red;
                    fillingTimeTextBox.Focus();
                    exceptionInformationLabel.Text = ex.Message;
                    SendExceptionInformationInTxt(myPath, ex);
                    return;
                }
            }
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (fillWithTimerCheckBox.Checked)
                {
                    arrayDataGridView.Refresh();
                    System.Threading.Thread.Sleep(timerCoolDown);
                }
                arrayDataGridView.Rows[0].Cells[i].Style.BackColor = Color.Empty;
                arrayDataGridView.Rows[0].Cells[i].Value = rnd.Next(-100, 100);
            }
        }

        private void findSumButton_Click(object sender, EventArgs e)
        {
            exceptionInformationLabel.Text = "";
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int number = 0;
                try
                {
                    if (string.IsNullOrEmpty(Convert.ToString(arrayDataGridView.Rows[0].Cells[i].Value)))
                        throw new Exception("Ячейка не может быть пустой.");
                    number = Convert.ToInt32(arrayDataGridView.Rows[0].Cells[i].Value);
                }
                catch (Exception ex)
                {
                    exceptionInformationLabel.Text = ex.Message;
                    arrayDataGridView.Rows[0].Cells[i].Style.BackColor = Color.Red;
                    arrayDataGridView.CurrentCell = arrayDataGridView.Rows[0].Cells[i];
                    arrayDataGridView.BeginEdit(true);
                    exceptionInformationLabel.Text = ex.Message;
                    SendExceptionInformationInTxt(myPath, ex);
                    return;
                }
                if (number > 0) sum += number;
                arrayDataGridView.Rows[0].Cells[i].Style.BackColor = Color.Empty;
            }
            findSumResultLabel.Text = "sum: " + 2 * sum;
        }

        private void printIndexButton_Click(object sender, EventArgs e)
        {
            printIndexLabel.Text = "";
            exceptionInformationLabel.Text = "";
            int prevValue = 0;
            try
            {
                if (string.IsNullOrEmpty(Convert.ToString(arrayDataGridView.Rows[0].Cells[0].Value)))
                    throw new Exception("Ячейка не может быть пустой.");
                prevValue = Convert.ToInt32(arrayDataGridView.Rows[0].Cells[0].Value);
            }
            catch (Exception ex)
            {
                exceptionInformationLabel.Text = ex.Message;
                arrayDataGridView.Rows[0].Cells[0].Style.BackColor = Color.Red;
                arrayDataGridView.CurrentCell = arrayDataGridView.Rows[0].Cells[0];
                arrayDataGridView.BeginEdit(true);
                exceptionInformationLabel.Text = ex.Message;
                SendExceptionInformationInTxt(myPath, ex);
                return;
            }
            int currentValue = 0;
            for (int i = 1; i < 10; i++)
            {
                try
                {
                    if (string.IsNullOrEmpty(Convert.ToString(arrayDataGridView.Rows[0].Cells[i].Value)))
                        throw new Exception("Ячейка не может быть пустой.");
                    currentValue = Convert.ToInt32(arrayDataGridView.Rows[0].Cells[i].Value);
                }
                catch (Exception ex)
                {
                    exceptionInformationLabel.Text = ex.Message;
                    arrayDataGridView.Rows[0].Cells[i].Style.BackColor = Color.Red;
                    arrayDataGridView.CurrentCell = arrayDataGridView.Rows[0].Cells[i];
                    arrayDataGridView.BeginEdit(true);
                    exceptionInformationLabel.Text = ex.Message;
                    SendExceptionInformationInTxt(myPath, ex);
                    return;
                }
                if (currentValue > prevValue) printIndexLabel.Text += i + " ";
                prevValue = currentValue;
            }
        }

        private void findSameSignNumbersButton_Click(object sender, EventArgs e)
        {
            exceptionInformationLabel.Text = "";
            int count = 0;
            int prevValue = 0;
            try
            {
                if (string.IsNullOrEmpty(Convert.ToString(arrayDataGridView.Rows[0].Cells[0].Value)))
                    throw new Exception("Ячейка не может быть пустой.");
                prevValue = Convert.ToInt32(arrayDataGridView.Rows[0].Cells[0].Value);
            }
            catch (Exception ex)
            {
                exceptionInformationLabel.Text = ex.Message;
                arrayDataGridView.Rows[0].Cells[0].Style.BackColor = Color.Red;
                arrayDataGridView.CurrentCell = arrayDataGridView.Rows[0].Cells[0];
                arrayDataGridView.BeginEdit(true);
                exceptionInformationLabel.Text = ex.Message;
                SendExceptionInformationInTxt(myPath, ex);
                return;
            }
            int currentValue = 0;
            for (int i = 1; i < 10; i++)
            {
                try
                {
                    if (string.IsNullOrEmpty(Convert.ToString(arrayDataGridView.Rows[0].Cells[i].Value)))
                        throw new Exception("Ячейка не может быть пустой.");
                    currentValue = Convert.ToInt32(arrayDataGridView.Rows[0].Cells[i].Value);
                }
                catch (Exception ex)
                {
                    exceptionInformationLabel.Text = ex.Message;
                    arrayDataGridView.Rows[0].Cells[i].Style.BackColor = Color.Red;
                    arrayDataGridView.CurrentCell = arrayDataGridView.Rows[0].Cells[i];
                    arrayDataGridView.BeginEdit(true);
                    exceptionInformationLabel.Text = ex.Message;
                    SendExceptionInformationInTxt(myPath, ex);
                    return;
                }

                if (prevValue > 0 && currentValue > 0) count++;
                if (prevValue < 0 && currentValue < 0) count++;

                if (count == 2)
                {
                    sameSignNumbersIndexLabel.Text = "YES";
                }

                prevValue = currentValue;
            }
            if (count<2) sameSignNumbersIndexLabel.Text = "NO";
        }

        private string caesarEncode(string str, int shift)
        {
            if (str == "")
            {
                return str;
            }
            string buf = null;
            for (int i = 0; i < str.Length; i++)
            {
                buf += (char)((char)str[i] + shift);
            }
            return buf;
        }
        private string caesarDecode(string str, int shift)
        {
            if (str == "")
            {
                return str;
            }
            string buf = null;
            for (int i = 0; i < str.Length; i++)
            {
                buf += (char)((char)str[i] - shift);
            }
            return buf;
        }
        private void buttonEncode_Click(object sender, EventArgs e)
        {
            exception2InformationLabel.Text = "";
            try
            {
                if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text))
                    throw new Exception("Ячейка не может быть пустой.");
                string buf = caesarEncode(textBoxName.Text, (int)numericUpDownShift.Value); textBoxName.Clear();
                textBoxName.Text = buf;
                buf = caesarEncode(textBoxSurname.Text, (int)numericUpDownShift.Value); textBoxSurname.Clear();
                textBoxSurname.Text = buf;
            }
            catch (Exception ex)
            {
                exception2InformationLabel.Text = ex.Message;
                textBoxName.BackColor = Color.Red;
                textBoxSurname.BackColor = Color.Red;
                SendExceptionInformationInTxt(myPath, ex);
                return;
            }
            textBoxName.BackColor = Color.Empty;
            textBoxSurname.BackColor = Color.Empty;
        }

            private void buttonDecode_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text))
                    throw new Exception("Ячейка не может быть пустой.");
                string buf = caesarDecode(textBoxName.Text, (int)numericUpDownShift.Value);
                textBoxName.Clear(); textBoxName.Text = buf;
                buf = caesarDecode(textBoxSurname.Text, (int)numericUpDownShift.Value);
                textBoxSurname.Clear(); textBoxSurname.Text = buf;
            }
            catch (Exception ex)
            {
                exception2InformationLabel.Text = ex.Message;
                textBoxName.BackColor = Color.Red;
                textBoxSurname.BackColor = Color.Red;
                SendExceptionInformationInTxt(myPath, ex);
                return;
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
