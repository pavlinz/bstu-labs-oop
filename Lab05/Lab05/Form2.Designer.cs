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
            this.label1 = new System.Windows.Forms.Label();
            this.clientNameBox = new System.Windows.Forms.TextBox();
            this.brithdayPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.telBox = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brithday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // clientNameBox
            // 
            this.clientNameBox.Location = new System.Drawing.Point(15, 25);
            this.clientNameBox.Name = "clientNameBox";
            this.clientNameBox.Size = new System.Drawing.Size(301, 20);
            this.clientNameBox.TabIndex = 1;
            // 
            // brithdayPicker
            // 
            this.brithdayPicker.Location = new System.Drawing.Point(15, 76);
            this.brithdayPicker.Name = "brithdayPicker";
            this.brithdayPicker.Size = new System.Drawing.Size(200, 20);
            this.brithdayPicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефон";
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(15, 133);
            this.telBox.Mask = "(999) 000-0000";
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(200, 20);
            this.telBox.TabIndex = 5;
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
            this.dataGridView.Location = new System.Drawing.Point(15, 248);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(609, 278);
            this.dataGridView.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить информацию в БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brithdayPicker);
            this.Controls.Add(this.clientNameBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Owner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientNameBox;
        private System.Windows.Forms.DateTimePicker brithdayPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox telBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn brithday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}