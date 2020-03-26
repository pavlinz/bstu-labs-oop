using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab05
{
    public partial class AccountForm : Form
    {
        #region AccountData
        private SearchForm searchForm;
        private SortForm sortForm;

        public Account acc = new Account();

        public enum SearchType
        {
            Number = 1,
            FullName,
            Balance,
            TypeOfDeposit
        }

        public enum SortType
        {
            CreatingDate = 1,
            Balance
        }

        public List<Account> list = new List<Account>();

        Timer timer = new Timer();

        public AccountForm()
        {
            InitializeComponent();
            this.addData.Enabled = false;
            this.xmlSaver.Enabled = false;

            this.accNumberField.Tag = false;
            this.groupBox.Tag = false;
            this.dateTimePicker.Tag = false;
            this.clientNameBox.Tag = false;

            this.accNumberField.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            this.groupBox.Validating += new System.ComponentModel.CancelEventHandler(this.groupBoxEmpty_Validating);
            this.clientNameBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);

            foreach(var item in SearchMenuItem.DropDownItems)
            {
                ((ToolStripMenuItem)item).Click += SearchMenuItems_Click;
            }

            foreach (var item in SortMenuItem.DropDownItems)
            {
                ((ToolStripMenuItem)item).Click += SortMenuItems_Click;
            }

            timer.Tick += new EventHandler(RefreshLabel);
            timer.Interval = 1000;
            timer.Start();
        }
        #endregion

        #region Validating

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
            (bool)(this.groupBox.Tag) && (bool)(this.clientNameBox.Tag));
        }
        #endregion

        #region ManageElements
        private void trackBalance_Scroll(object sender, EventArgs e)
        {
            trackValue.Text = Convert.ToString(trackBalance.Value);
        }

        private void accNumberField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void addData_Click(object sender, EventArgs e)
        {
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

            acc.Passport = passData.Text;

            if (checkSms.Checked)
                acc.smsAlert = true;

            acc.owner.FullName = clientNameBox.Text;
            acc.owner.DateOfBitrh = brithdayPicker.Text;
            acc.owner.Tel = telBox.Text;

            var results = new List<ValidationResult>();
            var context = new ValidationContext(acc);
            if (!Validator.TryValidateObject(acc, context, results, true))
            {
                foreach (var error in results)
                {
                    string strWithErrroe = error.ErrorMessage;
                    MessageBox.Show(strWithErrroe, "Сообщение");
                }
            }
            else
            {
                Owner ownerObj = new Owner
                {
                    FullName = acc.owner.FullName,
                    DateOfBitrh = acc.owner.DateOfBitrh,
                    Tel = acc.owner.Tel
                };
                list.Add(new Account
                {
                    Number = acc.Number,
                    TypeOfDeposit = acc.TypeOfDeposit,
                    Balance = acc.Balance,
                    CreatingDate = acc.CreatingDate,
                    smsAlert = acc.smsAlert,
                    owner = ownerObj
                });

                accNumberField.Clear();
                clientNameBox.Clear();
                telBox.Clear();
                passData.Clear();

                this.xmlSaver.Enabled = true;
            }
        }

        private void ownerInfButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
        }

        private void xmlSaver_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Account>));

            using (FileStream fs = new FileStream("accounts.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }


        #endregion

        #region MenuEvents
        private void SearchMenuItems_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            if (list.Count != 0)
            {
                switch (menuItem.Text)
                {
                    case "Номер":
                        searchForm = new SearchForm(SearchType.Number, this);
                        Label numbLabel = new Label
                        {
                            AutoSize = true,
                            Location = new Point(15, 15),
                            Text = "Введите номер счета: "
                        };
                        searchForm.Controls.Add(numbLabel);
                        searchForm.Show();
                        break;
                    case "ФИО":
                        searchForm = new SearchForm(SearchType.FullName, this);
                        Label FullNameLabel = new Label
                        {
                            AutoSize = true,
                            Location = new Point(15, 15),
                            Text = "Введите полное имя: "
                        };
                        searchForm.Controls.Add(FullNameLabel);
                        searchForm.Show();
                        break;
                    case "Баланс":
                        searchForm = new SearchForm(SearchType.Balance, this);
                        Label BalanceLabel = new Label
                        {
                            AutoSize = true,
                            Location = new Point(15, 15),
                            Text = "Введите баланс: "
                        };
                        searchForm.Controls.Add(BalanceLabel);
                        searchForm.Show();
                        break;
                    case "Тип вклада":
                        searchForm = new SearchForm(SearchType.TypeOfDeposit, this);
                        Label DepositTypeLabel = new Label
                        {
                            AutoSize = true,
                            Location = new Point(15, 15),
                            Text = "Введите тип вклада: "
                        };
                        searchForm.Controls.Add(DepositTypeLabel);
                        searchForm.Show();
                        break;
                }
            }
        }

        private void SortMenuItems_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            if (list.Count != 0)
            {
                switch (menuItem.Text)
                {
                    case "Дата открытия счета":
                        sortForm = new SortForm(SortType.CreatingDate, this);
                        sortForm.Show();
                        break;
                    case "Баланс":
                        sortForm = new SortForm(SortType.Balance, this);
                        sortForm.Show();
                        break;
                }
            }
        }

        private void AboutProgMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramm aboutProgramm = new AboutProgramm();
            aboutProgramm.Show();
        }
        #endregion

        public void RefreshLabel(object sender, EventArgs e)
        {
            stateString.Text = "Количество объектов: " + list.Count + "\n" + 
                                DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
