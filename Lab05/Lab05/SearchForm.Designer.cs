namespace Lab05
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchView = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchView
            // 
            this.searchView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.DateOfBirth,
            this.Tel,
            this.Number,
            this.TypeOfDeposit,
            this.Balance});
            this.searchView.Location = new System.Drawing.Point(12, 73);
            this.searchView.Name = "searchView";
            this.searchView.Size = new System.Drawing.Size(571, 280);
            this.searchView.TabIndex = 0;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Дата рождения";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Телефон";
            this.Tel.Name = "Tel";
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер счета";
            this.Number.Name = "Number";
            // 
            // TypeOfDeposit
            // 
            this.TypeOfDeposit.HeaderText = "Типп вклада";
            this.TypeOfDeposit.Name = "TypeOfDeposit";
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Баланс";
            this.Balance.Name = "Balance";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 33);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(288, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 377);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchView);
            this.Name = "SearchForm";
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.searchView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.TextBox searchBox;
    }
}