using System;
using System.Windows.Forms;

namespace Lab04
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += "1";
            Flags.NUM = true;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += "2";
            Flags.NUM = true;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += "3";
            Flags.NUM = true;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += "4";
            Flags.NUM = true;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += "5";
            Flags.NUM = true;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += "6";
            Flags.NUM = true;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += "7";
            Flags.NUM = true;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += "8";
            Flags.NUM = true;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += "9";
            Flags.NUM = true;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += "0";
            Flags.NUM = true;
        }

        private void leftBracket_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += "(";
        }

        private void rightBracket_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += ")";
            Flags.RB = true;
        }

        private void sinButton_Click(object sender, EventArgs e)
        {
            Flags.SIN = true;
            this.MainTextBox.Text += "sin(";
        }

        private void cosButton_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += "cos(";
            Flags.COS = true;
        }

        private void tanButton_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += "tan(";
            Flags.TAN = true;
        }

        private void point_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += ",";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if(this.MainTextBox.Text != String.Empty)
            {
                this.MainTextBox.Clear();
                Flags.SIN = false;
                Flags.COS = false;
                Flags.TAN = false;
                Flags.NUM = false;
                Flags.LB = false;
                Flags.RB = false;
                Flags.SQ = false;
                Flags.RAD = false;
            }   
        }

        private void ySquare_Click(object sender, EventArgs e)
        {
            string value = this.MainTextBox.Text;

            this.MainTextBox.Clear();

            this.MainTextBox.Text += Math.Pow(Double.Parse(value), 2);
        }

        private void radical_Click(object sender, EventArgs e)
        {
            this.MainTextBox.Text += "√";
            Flags.RAD = true;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                if (Flags.SIN && Flags.NUM)
                {
                    string value = this.MainTextBox.Text;

                    value = value.Remove(0, 4);

                    if (Flags.RB)
                        value = value.Remove(value.Length - 1);

                    this.MainTextBox.Clear();

                    this.MainTextBox.Text += Math.Sin(Math.PI * Double.Parse(value) / 180);
                }
                else if (Flags.COS && Flags.NUM)
                {
                    string value = this.MainTextBox.Text;

                    value = value.Remove(0, 4);

                    if (Flags.RB)
                        value = value.Remove(value.Length - 1);

                    this.MainTextBox.Clear();

                    double val = Double.Parse(value) * (Math.PI / 180);

                    this.MainTextBox.Text += Math.Sqrt(1 - Math.Sin(val) * Math.Sin(val));
                }
                else if (Flags.TAN && Flags.NUM)
                {
                    string value = this.MainTextBox.Text;

                    value = value.Remove(0, 4);

                    if (Flags.RB)
                        value = value.Remove(value.Length - 1);

                    this.MainTextBox.Clear();

                    if(((Double.Parse(value) - 90) % 180) == 0)
                    {
                        throw new Exception("Отсутствует значениe");
                    }

                    this.MainTextBox.Text += Math.Tan(Math.PI * Double.Parse(value) / 180);
                }
                else if (Flags.RAD && Flags.NUM)
                {
                    string value = this.MainTextBox.Text;

                    value = value.Remove(0, 1);

                    this.MainTextBox.Clear();

                    this.MainTextBox.Text += Math.Sqrt(Double.Parse(value));
                }
                else
                {
                    this.MainTextBox.Clear();
                    this.MainTextBox.Text = "Error";
                }
            }
            catch(Exception ex)
            {
                this.MainTextBox.Text = ex.Message;
            }
        }

        private void saveValue_Click(object sender, EventArgs e)
        {
            try
            {
                double value;
                if (this.MainTextBox.Text != String.Empty)
                {
                    value = Double.Parse(this.MainTextBox.Text);
                    Keeper.AddValue(value);
                }
            }
            catch (Exception ex)
            {
                this.MainTextBox.Text = ex.Message;
            }
        }

        private void clearMemory_Click(object sender, EventArgs e)
        {
            Keeper.ClearMemory();
        }

        private void addValue_Click(object sender, EventArgs e)
        {
            if(Keeper.TakeValue() == 0)
            {
                this.MainTextBox.Clear();
                this.MainTextBox.Text = "Добавьте значение в память";
            }
            else
            {
                this.MainTextBox.Text += Convert.ToString(Keeper.TakeValue());
                Flags.NUM = true;
            }
            
        }
    }
}
