namespace Lab05
{
    partial class AccountForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.accNumberField = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.multiply = new System.Windows.Forms.RadioButton();
            this.manager = new System.Windows.Forms.RadioButton();
            this.saver = new System.Windows.Forms.RadioButton();
            this.trackBalance = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.trackValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkSms = new System.Windows.Forms.CheckBox();
            this.addData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.xmlSaver = new System.Windows.Forms.Button();
            this.ownerInfButton = new System.Windows.Forms.Button();
            this.telBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.brithdayPicker = new System.Windows.Forms.DateTimePicker();
            this.clientNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NumberSearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BalanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepositMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датаОткрытияСчетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.балансToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passData = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stateString = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBalance)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер:";
            // 
            // accNumberField
            // 
            this.accNumberField.Location = new System.Drawing.Point(12, 54);
            this.accNumberField.MaxLength = 6;
            this.accNumberField.Name = "accNumberField";
            this.accNumberField.Size = new System.Drawing.Size(202, 20);
            this.accNumberField.TabIndex = 1;
            this.accNumberField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accNumberField_KeyPress);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.multiply);
            this.groupBox.Controls.Add(this.manager);
            this.groupBox.Controls.Add(this.saver);
            this.groupBox.Location = new System.Drawing.Point(12, 97);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(202, 100);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Тип вклада";
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.Location = new System.Drawing.Point(7, 68);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(152, 17);
            this.multiply.TabIndex = 2;
            this.multiply.Text = "отзывной \"Приумножай\"";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // manager
            // 
            this.manager.AutoSize = true;
            this.manager.Location = new System.Drawing.Point(7, 45);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(137, 17);
            this.manager.TabIndex = 1;
            this.manager.Text = "отзывной \"Управляй\"";
            this.manager.UseVisualStyleBackColor = true;
            // 
            // saver
            // 
            this.saver.AutoSize = true;
            this.saver.Checked = true;
            this.saver.Location = new System.Drawing.Point(7, 20);
            this.saver.Name = "saver";
            this.saver.Size = new System.Drawing.Size(153, 17);
            this.saver.TabIndex = 0;
            this.saver.TabStop = true;
            this.saver.Text = "безотзывной \"Сохраняй\"";
            this.saver.UseVisualStyleBackColor = true;
            // 
            // trackBalance
            // 
            this.trackBalance.Location = new System.Drawing.Point(12, 248);
            this.trackBalance.Maximum = 2000;
            this.trackBalance.Name = "trackBalance";
            this.trackBalance.Size = new System.Drawing.Size(202, 45);
            this.trackBalance.TabIndex = 3;
            this.trackBalance.Scroll += new System.EventHandler(this.trackBalance_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Баланс:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(9, 323);
            this.dateTimePicker.MaxDate = new System.DateTime(2020, 3, 9, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.Value = new System.DateTime(2020, 3, 9, 0, 0, 0, 0);
            // 
            // trackValue
            // 
            this.trackValue.AutoSize = true;
            this.trackValue.Location = new System.Drawing.Point(62, 223);
            this.trackValue.Name = "trackValue";
            this.trackValue.Size = new System.Drawing.Size(13, 13);
            this.trackValue.TabIndex = 6;
            this.trackValue.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дополнительные возможности:";
            // 
            // checkSms
            // 
            this.checkSms.AutoSize = true;
            this.checkSms.Location = new System.Drawing.Point(19, 415);
            this.checkSms.Name = "checkSms";
            this.checkSms.Size = new System.Drawing.Size(113, 17);
            this.checkSms.TabIndex = 8;
            this.checkSms.Text = "Смс оповещение";
            this.checkSms.UseVisualStyleBackColor = true;
            // 
            // addData
            // 
            this.addData.Location = new System.Drawing.Point(9, 494);
            this.addData.Name = "addData";
            this.addData.Size = new System.Drawing.Size(202, 43);
            this.addData.TabIndex = 9;
            this.addData.Text = "Добавить";
            this.addData.UseVisualStyleBackColor = true;
            this.addData.Click += new System.EventHandler(this.addData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата создания счета:";
            // 
            // xmlSaver
            // 
            this.xmlSaver.Location = new System.Drawing.Point(9, 608);
            this.xmlSaver.Name = "xmlSaver";
            this.xmlSaver.Size = new System.Drawing.Size(202, 23);
            this.xmlSaver.TabIndex = 12;
            this.xmlSaver.Text = "Сохранение инфорации в  XML";
            this.xmlSaver.UseVisualStyleBackColor = true;
            this.xmlSaver.Click += new System.EventHandler(this.xmlSaver_Click);
            // 
            // ownerInfButton
            // 
            this.ownerInfButton.Location = new System.Drawing.Point(9, 553);
            this.ownerInfButton.Name = "ownerInfButton";
            this.ownerInfButton.Size = new System.Drawing.Size(202, 37);
            this.ownerInfButton.TabIndex = 13;
            this.ownerInfButton.Text = "Таблица";
            this.ownerInfButton.UseVisualStyleBackColor = true;
            this.ownerInfButton.Click += new System.EventHandler(this.ownerInfButton_Click);
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(254, 162);
            this.telBox.Mask = "(999) 000-0000";
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(200, 20);
            this.telBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Дата рождения";
            // 
            // brithdayPicker
            // 
            this.brithdayPicker.Location = new System.Drawing.Point(254, 105);
            this.brithdayPicker.Name = "brithdayPicker";
            this.brithdayPicker.Size = new System.Drawing.Size(200, 20);
            this.brithdayPicker.TabIndex = 17;
            // 
            // clientNameBox
            // 
            this.clientNameBox.Location = new System.Drawing.Point(254, 54);
            this.clientNameBox.MaxLength = 50;
            this.clientNameBox.Name = "clientNameBox";
            this.clientNameBox.Size = new System.Drawing.Size(301, 20);
            this.clientNameBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ФИО";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchMenuItem,
            this.SortMenuItem,
            this.AboutProgMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SearchMenuItem
            // 
            this.SearchMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NumberSearchMenuItem,
            this.FullNameMenuItem,
            this.BalanceMenuItem,
            this.DepositMenuItem});
            this.SearchMenuItem.Name = "SearchMenuItem";
            this.SearchMenuItem.Size = new System.Drawing.Size(54, 20);
            this.SearchMenuItem.Text = "Поиск";
            // 
            // NumberSearchMenuItem
            // 
            this.NumberSearchMenuItem.Name = "NumberSearchMenuItem";
            this.NumberSearchMenuItem.Size = new System.Drawing.Size(135, 22);
            this.NumberSearchMenuItem.Text = "Номер";
            // 
            // FullNameMenuItem
            // 
            this.FullNameMenuItem.Name = "FullNameMenuItem";
            this.FullNameMenuItem.Size = new System.Drawing.Size(135, 22);
            this.FullNameMenuItem.Text = "ФИО";
            // 
            // BalanceMenuItem
            // 
            this.BalanceMenuItem.Name = "BalanceMenuItem";
            this.BalanceMenuItem.Size = new System.Drawing.Size(135, 22);
            this.BalanceMenuItem.Text = "Баланс";
            // 
            // DepositMenuItem
            // 
            this.DepositMenuItem.Name = "DepositMenuItem";
            this.DepositMenuItem.Size = new System.Drawing.Size(135, 22);
            this.DepositMenuItem.Text = "Тип вклада";
            // 
            // SortMenuItem
            // 
            this.SortMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.датаОткрытияСчетаToolStripMenuItem,
            this.балансToolStripMenuItem1});
            this.SortMenuItem.Name = "SortMenuItem";
            this.SortMenuItem.Size = new System.Drawing.Size(85, 20);
            this.SortMenuItem.Text = "Сортировка";
            // 
            // датаОткрытияСчетаToolStripMenuItem
            // 
            this.датаОткрытияСчетаToolStripMenuItem.Name = "датаОткрытияСчетаToolStripMenuItem";
            this.датаОткрытияСчетаToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.датаОткрытияСчетаToolStripMenuItem.Text = "Дата открытия счета";
            // 
            // балансToolStripMenuItem1
            // 
            this.балансToolStripMenuItem1.Name = "балансToolStripMenuItem1";
            this.балансToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.балансToolStripMenuItem1.Text = "Баланс";
            // 
            // AboutProgMenuItem
            // 
            this.AboutProgMenuItem.Name = "AboutProgMenuItem";
            this.AboutProgMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutProgMenuItem.Text = "О программе";
            this.AboutProgMenuItem.Click += new System.EventHandler(this.AboutProgMenuItem_Click);
            // 
            // passData
            // 
            this.passData.Location = new System.Drawing.Point(254, 215);
            this.passData.Name = "passData";
            this.passData.Size = new System.Drawing.Size(200, 20);
            this.passData.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Паспортные данные";
            // 
            // stateString
            // 
            this.stateString.AutoSize = true;
            this.stateString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateString.Location = new System.Drawing.Point(254, 307);
            this.stateString.Name = "stateString";
            this.stateString.Size = new System.Drawing.Size(0, 24);
            this.stateString.TabIndex = 24;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 672);
            this.Controls.Add(this.stateString);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.passData);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.brithdayPicker);
            this.Controls.Add(this.clientNameBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ownerInfButton);
            this.Controls.Add(this.xmlSaver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addData);
            this.Controls.Add(this.checkSms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackValue);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBalance);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.accNumberField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AccountForm";
            this.Text = "Счет";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBalance)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accNumberField;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton multiply;
        private System.Windows.Forms.RadioButton manager;
        private System.Windows.Forms.RadioButton saver;
        private System.Windows.Forms.TrackBar trackBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label trackValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkSms;
        private System.Windows.Forms.Button addData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button xmlSaver;
        private System.Windows.Forms.Button ownerInfButton;
        private System.Windows.Forms.MaskedTextBox telBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker brithdayPicker;
        private System.Windows.Forms.TextBox clientNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SearchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NumberSearchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FullNameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BalanceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DepositMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датаОткрытияСчетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem балансToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AboutProgMenuItem;
        private System.Windows.Forms.TextBox passData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label stateString;
    }
}

