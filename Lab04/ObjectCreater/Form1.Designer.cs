namespace ObjectCreater
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.CreateCollection = new System.Windows.Forms.Button();
            this.descendingSort = new System.Windows.Forms.Button();
            this.ascendingSort = new System.Windows.Forms.Button();
            this.entireCollection = new System.Windows.Forms.ListView();
            this.showResult = new System.Windows.Forms.ListView();
            this.findMinValue = new System.Windows.Forms.Button();
            this.findMaxValue = new System.Windows.Forms.Button();
            this.counterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер коллекции";
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(359, 25);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(100, 20);
            this.CountBox.TabIndex = 1;
            // 
            // CreateCollection
            // 
            this.CreateCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateCollection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateCollection.Location = new System.Drawing.Point(318, 94);
            this.CreateCollection.Name = "CreateCollection";
            this.CreateCollection.Size = new System.Drawing.Size(185, 40);
            this.CreateCollection.TabIndex = 2;
            this.CreateCollection.Text = "Сгенерировать коллекцию";
            this.CreateCollection.UseVisualStyleBackColor = true;
            this.CreateCollection.Click += new System.EventHandler(this.CreateCollection_Click);
            // 
            // descendingSort
            // 
            this.descendingSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descendingSort.Location = new System.Drawing.Point(626, 94);
            this.descendingSort.Name = "descendingSort";
            this.descendingSort.Size = new System.Drawing.Size(185, 40);
            this.descendingSort.TabIndex = 3;
            this.descendingSort.Text = "Сортировать по убыванию";
            this.descendingSort.UseVisualStyleBackColor = true;
            this.descendingSort.Click += new System.EventHandler(this.descendingSort_Click);
            // 
            // ascendingSort
            // 
            this.ascendingSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ascendingSort.Location = new System.Drawing.Point(12, 94);
            this.ascendingSort.Name = "ascendingSort";
            this.ascendingSort.Size = new System.Drawing.Size(185, 40);
            this.ascendingSort.TabIndex = 4;
            this.ascendingSort.Text = "Сортировать по возрастанию";
            this.ascendingSort.UseVisualStyleBackColor = true;
            this.ascendingSort.Click += new System.EventHandler(this.ascendingSort_Click);
            // 
            // entireCollection
            // 
            this.entireCollection.HideSelection = false;
            this.entireCollection.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.entireCollection.Location = new System.Drawing.Point(12, 243);
            this.entireCollection.Name = "entireCollection";
            this.entireCollection.Size = new System.Drawing.Size(360, 190);
            this.entireCollection.TabIndex = 5;
            this.entireCollection.UseCompatibleStateImageBehavior = false;
            this.entireCollection.View = System.Windows.Forms.View.List;
            // 
            // showResult
            // 
            this.showResult.HideSelection = false;
            this.showResult.Location = new System.Drawing.Point(451, 243);
            this.showResult.Name = "showResult";
            this.showResult.Size = new System.Drawing.Size(360, 190);
            this.showResult.TabIndex = 6;
            this.showResult.UseCompatibleStateImageBehavior = false;
            this.showResult.View = System.Windows.Forms.View.List;
            // 
            // findMinValue
            // 
            this.findMinValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findMinValue.Location = new System.Drawing.Point(78, 170);
            this.findMinValue.Name = "findMinValue";
            this.findMinValue.Size = new System.Drawing.Size(120, 50);
            this.findMinValue.TabIndex = 7;
            this.findMinValue.Text = "Минимальные элемент";
            this.findMinValue.UseVisualStyleBackColor = true;
            this.findMinValue.Click += new System.EventHandler(this.findMinValue_Click);
            // 
            // findMaxValue
            // 
            this.findMaxValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findMaxValue.Location = new System.Drawing.Point(350, 170);
            this.findMaxValue.Name = "findMaxValue";
            this.findMaxValue.Size = new System.Drawing.Size(120, 50);
            this.findMaxValue.TabIndex = 8;
            this.findMaxValue.Text = "Максимальный элемент";
            this.findMaxValue.UseVisualStyleBackColor = true;
            this.findMaxValue.Click += new System.EventHandler(this.findMaxValue_Click);
            // 
            // counterButton
            // 
            this.counterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.counterButton.Location = new System.Drawing.Point(626, 170);
            this.counterButton.Name = "counterButton";
            this.counterButton.Size = new System.Drawing.Size(120, 50);
            this.counterButton.TabIndex = 9;
            this.counterButton.Text = "Количество";
            this.counterButton.UseVisualStyleBackColor = true;
            this.counterButton.Click += new System.EventHandler(this.counterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 460);
            this.Controls.Add(this.counterButton);
            this.Controls.Add(this.findMaxValue);
            this.Controls.Add(this.findMinValue);
            this.Controls.Add(this.showResult);
            this.Controls.Add(this.entireCollection);
            this.Controls.Add(this.ascendingSort);
            this.Controls.Add(this.descendingSort);
            this.Controls.Add(this.CreateCollection);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.Button CreateCollection;
        private System.Windows.Forms.Button descendingSort;
        private System.Windows.Forms.Button ascendingSort;
        private System.Windows.Forms.ListView entireCollection;
        private System.Windows.Forms.ListView showResult;
        private System.Windows.Forms.Button findMinValue;
        private System.Windows.Forms.Button findMaxValue;
        private System.Windows.Forms.Button counterButton;
    }
}

