namespace BudgetTracker
{
    partial class TransactionEntryForm
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
            this.IncomeRadioButton = new System.Windows.Forms.RadioButton();
            this.ExpenseRadioButton = new System.Windows.Forms.RadioButton();
            this.Amount = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.TextBox();
            this.Currency = new System.Windows.Forms.TextBox();
            this.Merch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Taxable = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.receivableComboBox = new System.Windows.Forms.ComboBox();
            this.loanComboBox = new System.Windows.Forms.ComboBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IncomeRadioButton
            // 
            this.IncomeRadioButton.AutoSize = true;
            this.IncomeRadioButton.Location = new System.Drawing.Point(80, 94);
            this.IncomeRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IncomeRadioButton.Name = "IncomeRadioButton";
            this.IncomeRadioButton.Size = new System.Drawing.Size(72, 20);
            this.IncomeRadioButton.TabIndex = 0;
            this.IncomeRadioButton.TabStop = true;
            this.IncomeRadioButton.Text = "Income";
            this.IncomeRadioButton.UseVisualStyleBackColor = true;
            this.IncomeRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ExpenseRadioButton
            // 
            this.ExpenseRadioButton.AutoSize = true;
            this.ExpenseRadioButton.Location = new System.Drawing.Point(80, 161);
            this.ExpenseRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExpenseRadioButton.Name = "ExpenseRadioButton";
            this.ExpenseRadioButton.Size = new System.Drawing.Size(81, 20);
            this.ExpenseRadioButton.TabIndex = 1;
            this.ExpenseRadioButton.TabStop = true;
            this.ExpenseRadioButton.Text = "Expense";
            this.ExpenseRadioButton.UseVisualStyleBackColor = true;
            this.ExpenseRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(99, 260);
            this.Amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(132, 22);
            this.Amount.TabIndex = 2;
            this.Amount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(269, 260);
            this.Description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(225, 22);
            this.Description.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 322);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Custom date ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(535, 260);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(181, 22);
            this.Category.TabIndex = 9;
            // 
            // Currency
            // 
            this.Currency.Location = new System.Drawing.Point(753, 260);
            this.Currency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(199, 22);
            this.Currency.TabIndex = 10;
            // 
            // Merch
            // 
            this.Merch.Location = new System.Drawing.Point(201, 161);
            this.Merch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Merch.Name = "Merch";
            this.Merch.Size = new System.Drawing.Size(295, 22);
            this.Merch.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Merchant name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(749, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Currency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Register new transaction";
            // 
            // Taxable
            // 
            this.Taxable.AutoSize = true;
            this.Taxable.Location = new System.Drawing.Point(201, 94);
            this.Taxable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Taxable.Name = "Taxable";
            this.Taxable.Size = new System.Drawing.Size(79, 20);
            this.Taxable.TabIndex = 17;
            this.Taxable.Text = "Taxable";
            this.Taxable.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(945, 36);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 45);
            this.button2.TabIndex = 19;
            this.button2.Text = "🏠︎";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Receivable(Optional):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Loan(Optional):";
            // 
            // receivableComboBox
            // 
            this.receivableComboBox.FormattingEnabled = true;
            this.receivableComboBox.Location = new System.Drawing.Point(528, 284);
            this.receivableComboBox.Name = "receivableComboBox";
            this.receivableComboBox.Size = new System.Drawing.Size(121, 21);
            this.receivableComboBox.TabIndex = 22;
            // 
            // loanComboBox
            // 
            this.loanComboBox.FormattingEnabled = true;
            this.loanComboBox.Location = new System.Drawing.Point(528, 311);
            this.loanComboBox.Name = "loanComboBox";
            this.loanComboBox.Size = new System.Drawing.Size(121, 21);
            this.loanComboBox.TabIndex = 23;
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(852, 366);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(100, 28);
            this.homeButton.TabIndex = 20;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // TransactionEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.loanComboBox);
            this.Controls.Add(this.receivableComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.ClientSize = new System.Drawing.Size(1035, 491);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Taxable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Merch);
            this.Controls.Add(this.Currency);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.ExpenseRadioButton);
            this.Controls.Add(this.IncomeRadioButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TransactionEntryForm";
            this.Text = "EntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton IncomeRadioButton;
        private System.Windows.Forms.RadioButton ExpenseRadioButton;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox Currency;
        private System.Windows.Forms.TextBox Merch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox Taxable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox receivableComboBox;
        private System.Windows.Forms.ComboBox loanComboBox;
        private System.Windows.Forms.Button homeButton;
    }
}