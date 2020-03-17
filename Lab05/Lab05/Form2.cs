using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form2 : Form
    {
        public string AccountNumber
        {
            get { return dataGridView.Rows[0].Cells["AccNumber"].Value.ToString(); }
            set { dataGridView.Rows[0].Cells["AccNumber"].Value = value; }
        }

        public string TypeDP
        {
            get { return dataGridView.Rows[0].Cells["TypeOfDeposit"].Value.ToString(); }
            set { dataGridView.Rows[0].Cells["TypeOfDeposit"].Value = value; }
        }

        public string AccBalance
        {
            get { return dataGridView.Rows[0].Cells["Balance"].Value.ToString(); }
            set { dataGridView.Rows[0].Cells["Balance"].Value = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.Rows[0].Cells["ClientName"].Value = clientNameBox.Text;
            dataGridView.Rows[0].Cells["brithday"].Value = brithdayPicker.Text;
            dataGridView.Rows[0].Cells["Tel"].Value = telBox.Text;
        }
    }
}
