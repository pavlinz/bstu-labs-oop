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

        private void outputData_Click(object sender, EventArgs e)
        {
            int rowNumber = 0;
            foreach (var item in accForm.list)
            {
                if (rowNumber != 0)
                {
                    rowNumber = dataGridView.Rows.Add();
                }

                dataGridView.Rows[rowNumber].Cells["ClientName"].Value = item.owner.FullName;
                dataGridView.Rows[rowNumber].Cells["brithday"].Value = item.owner.DateOfBitrh;
                dataGridView.Rows[rowNumber].Cells["Tel"].Value = item.owner.Tel;
                dataGridView.Rows[rowNumber].Cells["AccNumber"].Value = item.Number;
                dataGridView.Rows[rowNumber].Cells["TypeOfDeposit"].Value = item.TypeOfDeposit;
                dataGridView.Rows[rowNumber].Cells["Balance"].Value = item.Balance;
                rowNumber++;
            }
        }
    }
}
