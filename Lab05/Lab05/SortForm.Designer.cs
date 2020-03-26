namespace Lab05
{
    partial class SortForm
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
            this.sortView = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sortView)).BeginInit();
            this.SuspendLayout();
            // 
            // sortView
            // 
            this.sortView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sortView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.CreatingDate,
            this.DateOfBirth,
            this.Tel,
            this.Number,
            this.TypeOfDeposit,
            this.Balance});
            this.sortView.Location = new System.Drawing.Point(0, 1);
            this.sortView.Name = "sortView";
            this.sortView.Size = new System.Drawing.Size(623, 323);
            this.sortView.TabIndex = 1;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            // 
            // CreatingDate
            // 
            this.CreatingDate.HeaderText = "Дата создания";
            this.CreatingDate.Name = "CreatingDate";
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
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 324);
            this.Controls.Add(this.sortView);
            this.Name = "SortForm";
            this.Text = "SortForm";
            ((System.ComponentModel.ISupportInitialize)(this.sortView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sortView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}