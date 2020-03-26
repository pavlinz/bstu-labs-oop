using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Lab05.AccountForm;

namespace Lab05
{
    public partial class SortForm : Form
    {
        private SortType _type { get; set; }
        private AccountForm accForm;
        private List<Account> accounts;

        public SortForm()
        {
            InitializeComponent();
        }

        public SortForm(SortType type, AccountForm accountForm)
        {
            InitializeComponent();

            _type = type;
            accForm = accountForm;
            List<Account> accounts = new List<Account>();

            if (type == SortType.CreatingDate)
            {
                AddDataToTable(DateSort(accForm.list));
            }
            else if (type == SortType.Balance)
            {
                AddDataToTable(BalanceSort(accForm.list));
            }
        }

        private List<Account> DateSort(List<Account> accounts)
        {
            var selectedAccounts = accounts.OrderBy(x => Convert.ToDateTime(x.CreatingDate)).ToList();
            return selectedAccounts;
        }

        private List<Account> BalanceSort(List<Account> accounts)
        {
            var selectedAccounts = accounts.OrderBy(x => x.Balance).ToList();
            return selectedAccounts;
        }

        private void AddDataToTable(IEnumerable<Account> selectedItems)
        {
            int rowNumber = 0;
            for (int i = 0; i < selectedItems.Count() - 1; i++)
            {
                rowNumber = sortView.Rows.Add();
            }
            rowNumber = 0;
            foreach (var item in selectedItems)
            {
                sortView.Rows[rowNumber].Cells["FullName"].Value = item.owner.FullName;
                sortView.Rows[rowNumber].Cells["CreatingDate"].Value = item.CreatingDate;
                sortView.Rows[rowNumber].Cells["DateOfBirth"].Value = item.owner.DateOfBitrh;
                sortView.Rows[rowNumber].Cells["Tel"].Value = item.owner.Tel;
                sortView.Rows[rowNumber].Cells["Number"].Value = item.Number;
                sortView.Rows[rowNumber].Cells["TypeOfDeposit"].Value = item.TypeOfDeposit;
                sortView.Rows[rowNumber].Cells["Balance"].Value = item.Balance;
                rowNumber++;
            }


        }
    }
}
