namespace Lab04
{
    partial class MainForm
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
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.tanButton = new System.Windows.Forms.Button();
            this.radical = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.ySquare = new System.Windows.Forms.Button();
            this.leftBracket = new System.Windows.Forms.Button();
            this.rightBracket = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTextBox
            // 
            this.MainTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.MainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTextBox.Location = new System.Drawing.Point(15, 22);
            this.MainTextBox.MinimumSize = new System.Drawing.Size(351, 20);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ReadOnly = true;
            this.MainTextBox.Size = new System.Drawing.Size(445, 46);
            this.MainTextBox.TabIndex = 0;
            this.MainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.num1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.num2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.num3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.num4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.num5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.num6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.num7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.num8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.num9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.num0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.equal, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.sinButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cosButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tanButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.radical, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.point, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ySquare, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.leftBracket, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rightBracket, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 92);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 375);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // num1
            // 
            this.num1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1.Location = new System.Drawing.Point(3, 3);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(106, 40);
            this.num1.TabIndex = 0;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num2.Location = new System.Drawing.Point(115, 3);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(106, 40);
            this.num2.TabIndex = 1;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num3.Location = new System.Drawing.Point(227, 3);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(106, 40);
            this.num3.TabIndex = 2;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num4.Location = new System.Drawing.Point(3, 78);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(106, 40);
            this.num4.TabIndex = 3;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num5.Location = new System.Drawing.Point(115, 78);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(106, 40);
            this.num5.TabIndex = 4;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num6.Location = new System.Drawing.Point(227, 78);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(106, 40);
            this.num6.TabIndex = 5;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num7
            // 
            this.num7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num7.Location = new System.Drawing.Point(3, 153);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(106, 40);
            this.num7.TabIndex = 6;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num8.Location = new System.Drawing.Point(115, 153);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(106, 40);
            this.num8.TabIndex = 7;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num9.Location = new System.Drawing.Point(227, 153);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(106, 40);
            this.num9.TabIndex = 8;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num0
            // 
            this.num0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num0.Location = new System.Drawing.Point(115, 228);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(106, 40);
            this.num0.TabIndex = 9;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // clearButton
            // 
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(339, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 40);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // equal
            // 
            this.equal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(339, 78);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(106, 40);
            this.equal.TabIndex = 13;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // sinButton
            // 
            this.sinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sinButton.Location = new System.Drawing.Point(339, 153);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(106, 40);
            this.sinButton.TabIndex = 14;
            this.sinButton.Text = "sin";
            this.sinButton.UseVisualStyleBackColor = true;
            this.sinButton.Click += new System.EventHandler(this.sinButton_Click);
            // 
            // cosButton
            // 
            this.cosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cosButton.Location = new System.Drawing.Point(339, 228);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(106, 40);
            this.cosButton.TabIndex = 15;
            this.cosButton.Text = "cos";
            this.cosButton.UseVisualStyleBackColor = true;
            this.cosButton.Click += new System.EventHandler(this.cosButton_Click);
            // 
            // tanButton
            // 
            this.tanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tanButton.Location = new System.Drawing.Point(339, 303);
            this.tanButton.Name = "tanButton";
            this.tanButton.Size = new System.Drawing.Size(106, 40);
            this.tanButton.TabIndex = 16;
            this.tanButton.Text = "tan";
            this.tanButton.UseVisualStyleBackColor = true;
            this.tanButton.Click += new System.EventHandler(this.tanButton_Click);
            // 
            // radical
            // 
            this.radical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radical.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radical.Location = new System.Drawing.Point(3, 303);
            this.radical.Name = "radical";
            this.radical.Size = new System.Drawing.Size(106, 40);
            this.radical.TabIndex = 10;
            this.radical.Text = "√x";
            this.radical.UseVisualStyleBackColor = true;
            this.radical.Click += new System.EventHandler(this.radical_Click);
            // 
            // point
            // 
            this.point.Cursor = System.Windows.Forms.Cursors.Hand;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.point.Location = new System.Drawing.Point(227, 303);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(106, 40);
            this.point.TabIndex = 17;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // ySquare
            // 
            this.ySquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ySquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ySquare.Location = new System.Drawing.Point(115, 303);
            this.ySquare.Name = "ySquare";
            this.ySquare.Size = new System.Drawing.Size(106, 40);
            this.ySquare.TabIndex = 18;
            this.ySquare.Text = "x²";
            this.ySquare.UseVisualStyleBackColor = true;
            this.ySquare.Click += new System.EventHandler(this.ySquare_Click);
            // 
            // leftBracket
            // 
            this.leftBracket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBracket.Location = new System.Drawing.Point(3, 228);
            this.leftBracket.Name = "leftBracket";
            this.leftBracket.Size = new System.Drawing.Size(106, 40);
            this.leftBracket.TabIndex = 19;
            this.leftBracket.Text = "(";
            this.leftBracket.UseVisualStyleBackColor = true;
            this.leftBracket.Click += new System.EventHandler(this.leftBracket_Click);
            // 
            // rightBracket
            // 
            this.rightBracket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBracket.Location = new System.Drawing.Point(227, 228);
            this.rightBracket.Name = "rightBracket";
            this.rightBracket.Size = new System.Drawing.Size(106, 40);
            this.rightBracket.TabIndex = 20;
            this.rightBracket.Text = ")";
            this.rightBracket.UseVisualStyleBackColor = true;
            this.rightBracket.Click += new System.EventHandler(this.rightBracket_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 479);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MainTextBox);
            this.Name = "MainForm";
            this.Text = "Калькулятор";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button sinButton;
        private System.Windows.Forms.Button cosButton;
        private System.Windows.Forms.Button tanButton;
        private System.Windows.Forms.Button radical;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button ySquare;
        private System.Windows.Forms.Button leftBracket;
        private System.Windows.Forms.Button rightBracket;
    }
}

