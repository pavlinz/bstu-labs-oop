using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;

namespace Lab05
{
    public partial class accountForm : Form
    {
        public Account acc;

        public accountForm()
        {
            InitializeComponent();
            this.addData.Enabled = false;
            this.xmlSaver.Enabled = false;
            this.xmlReader.Enabled = false;
            this.ownerInfButton.Enabled = false;

            this.accNumberField.Tag = false;
            this.groupBox.Tag = false;
            this.dateTimePicker.Tag = false;

            this.accNumberField.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            this.groupBox.Validating += new System.ComponentModel.CancelEventHandler(this.groupBoxEmpty_Validating);
        }

        private void textBoxEmpty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.IndianRed;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateAddData();
        }

        private void groupBoxEmpty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool counter = false;
            GroupBox gp = (GroupBox)sender;
            foreach (RadioButton item in gp.Controls)
            {
                if (item.Checked)
                {
                    counter = true;
                }
            }
            if(!counter)
            {
                gp.Tag = false;
            }
            else
            {
                gp.BackColor = System.Drawing.SystemColors.Window;
                gp.Tag = true;
            }
            ValidateAddData();
        }

        private void ValidateAddData()
        {
            this.addData.Enabled = ((bool)(this.accNumberField.Tag) &&
            (bool)(this.groupBox.Tag));
        }

        private void trackBalance_Scroll(object sender, EventArgs e)
        {
            trackValue.Text = Convert.ToString(trackBalance.Value);
        }

        private void accNumberField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void addData_Click(object sender, EventArgs e)
        {
            string output;

            output = "Номер счета: " + accNumberField.Text + "\n";

            foreach(RadioButton radio in groupBox.Controls)
            {
                if (radio.Checked)
                {
                    output += "Тип вклада: " + radio.Text + "\n";
                }
            }

            output += "Баланс: " + trackValue.Text + "\n";

            output += "Дата создания счета: " + dateTimePicker.Text + "\n";

            if (checkSms.Checked)
                output += "Смс оповещение подключено";

            outputData.Text = output;

            this.xmlSaver.Enabled = true;
        }

        private void xmlReader_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Account));
            string xmlString;

            using (FileStream fs = new FileStream("accounts.xml", FileMode.Open))
            {
                Account newPerson = (Account)formatter.Deserialize(fs);

                outputData.Clear();

                outputData.Text = $"Номер: {acc.Number} \nТип вклада: {acc.TypeOfDeposit} \n" +
                                  $"Баланс: {acc.Balance} \nДата создания: {acc.CreatingDate} \n" +
                                  $"Смс оповещение: {acc.smsAlert}";
            }
        }

        private void ownerInfButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.AccountNumber = accNumberField.Text;
            form.TypeDP = acc.TypeOfDeposit;
            form.AccBalance = acc.Balance.ToString();
            form.Show();
        }

        private void xmlSaver_Click(object sender, EventArgs e)
        {
            acc = new Account();

            acc.Number = accNumberField.Text;

            foreach (RadioButton radio in groupBox.Controls)
            {
                if (radio.Checked)
                {
                    acc.TypeOfDeposit += radio.Text;
                }
            }

            acc.Balance = Convert.ToInt32(trackValue.Text);

            acc.CreatingDate = dateTimePicker.Text;

            if (checkSms.Checked)
                acc.smsAlert = true;

            XmlSerializer formatter = new XmlSerializer(typeof(Account));

            using (FileStream fs = new FileStream("accounts.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, acc);
            }

            xmlReader.Enabled = true;
            ownerInfButton.Enabled = true;
        }
    }
}
