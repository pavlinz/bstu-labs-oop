namespace Lab05
{
    partial class Form2
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brithday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientName,
            this.brithday,
            this.Tel,
            this.AccNumber,
            this.TypeOfDeposit,
            this.Balance});
            this.dataGridView.Location = new System.Drawing.Point(15, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(609, 278);
            this.dataGridView.TabIndex = 6;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "ФИО";
            this.ClientName.Name = "ClientName";
            // 
            // brithday
            // 
            this.brithday.HeaderText = "Дата рождения";
            this.brithday.Name = "brithday";
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Телефон";
            this.Tel.Name = "Tel";
            // 
            // AccNumber
            // 
            this.AccNumber.HeaderText = "Номер счета";
            this.AccNumber.Name = "AccNumber";
            // 
            // TypeOfDeposit
            // 
            this.TypeOfDeposit.HeaderText = "Тип вклада";
            this.TypeOfDeposit.Name = "TypeOfDeposit";
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Баланс";
            this.Balance.Name = "Balance";
            // 
            // outputData
            // 
            this.outputData.Location = new System.Drawing.Point(218, 314);
            this.outputData.Name = "outputData";
            this.outputData.Size = new System.Drawing.Size(204, 47);
            this.outputData.TabIndex = 8;
            this.outputData.Text = "Вывести данные в таблицу";
            this.outputData.UseVisualStyleBackColor = true;
            this.outputData.Click += new System.EventHandler(this.outputData_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 660);
            this.Controls.Add(this.outputData);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form2";
            this.Text = "Owner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn brithday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.Button outputData;
    }
}