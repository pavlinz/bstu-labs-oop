using System;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;

namespace Lab05
{
    public partial class accountForm : Form
    {
        Account acc;

        public accountForm()
        {
            InitializeComponent();
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

            if(checkSms.Checked)
                output += "Смс оповещение подключено";

            outputData.Text = output;
        }

        private void jsonSaver_Click(object sender, EventArgs e)
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

            string jsonString;
            jsonString = JsonSerializer.Serialize(acc);
            File.WriteAllText("accounts.json", jsonString);
        }
    }
}
