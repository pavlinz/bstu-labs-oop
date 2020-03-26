using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Lab05.AccountForm;

namespace Lab05
{
    public partial class SearchForm : Form
    { 
        private SearchType SearchType { get; set; }
        private AccountForm accForm;
        private List<Account> accounts;

        public SearchForm(SearchType type, AccountForm accountForm)
        {
            InitializeComponent();
            if (type == SearchType.Number)
                this.searchBox.MaxLength = 6;

            SearchType = type;
            accForm = accountForm;
            accounts = new List<Account>();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            switch (SearchType)
            {
                case (SearchType)1:
                    var selectedItems = from item in accForm.list
                                 where item.Number == searchBox.Text
                                 select item;
                    AddDataToTable(selectedItems);
                    break;
                case (SearchType)2:
                    //selectedItems = from item in accForm.list
                    //                    where item.owner.FullName == searchBox.Text
                    //                    select item;
                    List<Account> selectedAccount = new List<Account>();
                    if (searchBox.Text != "")
                    {
                        string template = $"^[{searchBox.Text}]+";
                        Regex _regex = new Regex(template);
                        foreach (Account item in accForm.list)
                        {
                            if(_regex.IsMatch(item.owner.FullName))
                            {
                                selectedAccount.Add(item);
                            }
                        }
                        AddDataToTable(selectedAccount);
                    }
                    break;
                case (SearchType)3:
                    selectedItems = from item in accForm.list
                                    where item.Balance == Convert.ToInt32(searchBox.Text)
                                    select item;
                    AddDataToTable(selectedItems);
                    break;
                case (SearchType)4:
                    selectedItems = from item in accForm.list
                                        where item.TypeOfDeposit == searchBox.Text
                                        select item;
                    AddDataToTable(selectedItems);
                    break;
            }
        }

        private void AddDataToTable(IEnumerable<Account> selectedItems)
        {
            int rowNumber = 0;
            foreach (var item in selectedItems)
            {
                if (rowNumber != 0)
                {
                    rowNumber = searchView.Rows.Add();
                }
                searchView.Rows[rowNumber].Cells["FullName"].Value = item.owner.FullName;
                searchView.Rows[rowNumber].Cells["DateOfBirth"].Value = item.owner.DateOfBitrh;
                searchView.Rows[rowNumber].Cells["Tel"].Value = item.owner.Tel;
                searchView.Rows[rowNumber].Cells["Number"].Value = item.Number;
                searchView.Rows[rowNumber].Cells["TypeOfDeposit"].Value = item.TypeOfDeposit;
                searchView.Rows[rowNumber].Cells["Balance"].Value = item.Balance;
                rowNumber++;
            }
        }
    }
}
