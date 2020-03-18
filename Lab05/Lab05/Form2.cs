using System;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form2 : Form
    {
        public AccountForm accForm;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(AccountForm accountForm)
        {
            accForm = accountForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accForm.acc.Number = accForm.accountNumberField;
            accForm.FullNameGlobalField = clientNameBox.Text;
            accForm.DateOfBitrhGlobalField = brithdayPicker.Text;
            accForm.TelGlobalField = telBox.Text;

            accForm.list.Add(accForm.acc);
            
            clientNameBox.Clear();
            telBox.Clear();
        }

        private void outputData_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < accForm.list.Count; i++)
            {
                int rowNumber = dataGridView.Rows.Add();
                dataGridView.Rows[rowNumber].Cells["ClientName"].Value = accForm.acc.owner.FullName;
                dataGridView.Rows[rowNumber].Cells["brithday"].Value = accForm.acc.owner.DateOfBitrh;
                dataGridView.Rows[rowNumber].Cells["Tel"].Value = accForm.acc.owner.Tel;
                dataGridView.Rows[rowNumber].Cells["AccNumber"].Value = accForm.acc.Number;
                dataGridView.Rows[rowNumber].Cells["TypeOfDeposit"].Value = accForm.acc.TypeOfDeposit;
                dataGridView.Rows[rowNumber].Cells["Balance"].Value = accForm.acc.Balance;
            }
        }
    }
}
