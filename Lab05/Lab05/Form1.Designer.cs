namespace Lab05
{
    partial class accountForm
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
            this.outputData = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.jsonSaver = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер:";
            // 
            // accNumberField
            // 
            this.accNumberField.Location = new System.Drawing.Point(15, 29);
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
            this.groupBox.Location = new System.Drawing.Point(15, 72);
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
            this.multiply.TabStop = true;
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
            this.manager.TabStop = true;
            this.manager.Text = "отзывной \"Управляй\"";
            this.manager.UseVisualStyleBackColor = true;
            // 
            // saver
            // 
            this.saver.AutoSize = true;
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
            this.trackBalance.Location = new System.Drawing.Point(15, 223);
            this.trackBalance.Maximum = 2000;
            this.trackBalance.Name = "trackBalance";
            this.trackBalance.Size = new System.Drawing.Size(202, 45);
            this.trackBalance.TabIndex = 3;
            this.trackBalance.Scroll += new System.EventHandler(this.trackBalance_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Баланс:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 298);
            this.dateTimePicker.MaxDate = new System.DateTime(2020, 3, 9, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.Value = new System.DateTime(2020, 3, 9, 0, 0, 0, 0);
            // 
            // trackValue
            // 
            this.trackValue.AutoSize = true;
            this.trackValue.Location = new System.Drawing.Point(65, 198);
            this.trackValue.Name = "trackValue";
            this.trackValue.Size = new System.Drawing.Size(13, 13);
            this.trackValue.TabIndex = 6;
            this.trackValue.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дополнительные возможности:";
            // 
            // checkSms
            // 
            this.checkSms.AutoSize = true;
            this.checkSms.Location = new System.Drawing.Point(22, 390);
            this.checkSms.Name = "checkSms";
            this.checkSms.Size = new System.Drawing.Size(113, 17);
            this.checkSms.TabIndex = 8;
            this.checkSms.Text = "Смс оповещение";
            this.checkSms.UseVisualStyleBackColor = true;
            // 
            // addData
            // 
            this.addData.Location = new System.Drawing.Point(12, 451);
            this.addData.Name = "addData";
            this.addData.Size = new System.Drawing.Size(202, 43);
            this.addData.TabIndex = 9;
            this.addData.Text = "Добавить";
            this.addData.UseVisualStyleBackColor = true;
            this.addData.Click += new System.EventHandler(this.addData_Click);
            // 
            // outputData
            // 
            this.outputData.Location = new System.Drawing.Point(305, 29);
            this.outputData.Name = "outputData";
            this.outputData.Size = new System.Drawing.Size(274, 465);
            this.outputData.TabIndex = 10;
            this.outputData.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата создания счета:";
            // 
            // jsonSaver
            // 
            this.jsonSaver.Location = new System.Drawing.Point(339, 500);
            this.jsonSaver.Name = "jsonSaver";
            this.jsonSaver.Size = new System.Drawing.Size(202, 23);
            this.jsonSaver.TabIndex = 12;
            this.jsonSaver.Text = "Сохранение инфорации в JSON";
            this.jsonSaver.UseVisualStyleBackColor = true;
            this.jsonSaver.Click += new System.EventHandler(this.jsonSaver_Click);
            // 
            // accountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 660);
            this.Controls.Add(this.jsonSaver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputData);
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
            this.Name = "accountForm";
            this.Text = "Счет";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBalance)).EndInit();
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
        private System.Windows.Forms.RichTextBox outputData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button jsonSaver;
    }
}

