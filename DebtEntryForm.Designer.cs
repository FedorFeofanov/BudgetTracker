namespace BudgetTracker
{
    partial class DebtEntryForm
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.ReceivableRadioButton = new System.Windows.Forms.RadioButton();
            this.LoanRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.borrowerNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.expectedRepaymentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.repaymentCollectedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.interestRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LanderNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.debtTypeTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MinimumPaymentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.PaymentFrequencyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.repaymentCollectedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestRateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumPaymentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentFrequencyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(85, 377);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(100, 28);
            this.SubmitButton.TabIndex = 17;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Custom date ";
            // 
            // CustomDateTimePicker
            // 
            this.CustomDateTimePicker.Location = new System.Drawing.Point(85, 325);
            this.CustomDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomDateTimePicker.Name = "CustomDateTimePicker";
            this.CustomDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.CustomDateTimePicker.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Amount";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(85, 255);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(223, 22);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // ReceivableRadioButton
            // 
            this.ReceivableRadioButton.AutoSize = true;
            this.ReceivableRadioButton.Location = new System.Drawing.Point(84, 162);
            this.ReceivableRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReceivableRadioButton.Name = "ReceivableRadioButton";
            this.ReceivableRadioButton.Size = new System.Drawing.Size(98, 20);
            this.ReceivableRadioButton.TabIndex = 10;
            this.ReceivableRadioButton.TabStop = true;
            this.ReceivableRadioButton.Text = "Receivable";
            this.ReceivableRadioButton.UseVisualStyleBackColor = true;
            // 
            // LoanRadioButton
            // 
            this.LoanRadioButton.AutoSize = true;
            this.LoanRadioButton.Location = new System.Drawing.Point(85, 97);
            this.LoanRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoanRadioButton.Name = "LoanRadioButton";
            this.LoanRadioButton.Size = new System.Drawing.Size(58, 20);
            this.LoanRadioButton.TabIndex = 9;
            this.LoanRadioButton.TabStop = true;
            this.LoanRadioButton.Text = "Loan";
            this.LoanRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Register new debt";
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(1095, 377);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(100, 28);
            this.backbutton.TabIndex = 19;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // borrowerNameTextBox
            // 
            this.borrowerNameTextBox.Location = new System.Drawing.Point(307, 160);
            this.borrowerNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrowerNameTextBox.Name = "borrowerNameTextBox";
            this.borrowerNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.borrowerNameTextBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Borrower Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Expected Repayment Date:";
            // 
            // expectedRepaymentDateDateTimePicker
            // 
            this.expectedRepaymentDateDateTimePicker.Location = new System.Drawing.Point(622, 160);
            this.expectedRepaymentDateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expectedRepaymentDateDateTimePicker.Name = "expectedRepaymentDateDateTimePicker";
            this.expectedRepaymentDateDateTimePicker.Size = new System.Drawing.Size(228, 22);
            this.expectedRepaymentDateDateTimePicker.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(664, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Repayment Collected:";
            // 
            // repaymentCollectedNumericUpDown
            // 
            this.repaymentCollectedNumericUpDown.Location = new System.Drawing.Point(810, 303);
            this.repaymentCollectedNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repaymentCollectedNumericUpDown.Name = "repaymentCollectedNumericUpDown";
            this.repaymentCollectedNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.repaymentCollectedNumericUpDown.TabIndex = 25;
            // 
            // interestRateNumericUpDown
            // 
            this.interestRateNumericUpDown.Location = new System.Drawing.Point(500, 255);
            this.interestRateNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.interestRateNumericUpDown.Name = "interestRateNumericUpDown";
            this.interestRateNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.interestRateNumericUpDown.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(515, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Interest Rate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Lander Name:";
            // 
            // LanderNameTextBox
            // 
            this.LanderNameTextBox.Location = new System.Drawing.Point(307, 97);
            this.LanderNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LanderNameTextBox.Name = "LanderNameTextBox";
            this.LanderNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.LanderNameTextBox.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(922, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(984, 158);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 22);
            this.statusTextBox.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(895, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Debt Type:";
            // 
            // debtTypeTextBox
            // 
            this.debtTypeTextBox.Location = new System.Drawing.Point(984, 96);
            this.debtTypeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debtTypeTextBox.Name = "debtTypeTextBox";
            this.debtTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.debtTypeTextBox.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(551, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Due date:";
            // 
            // DueDateDateTimePicker
            // 
            this.DueDateDateTimePicker.Location = new System.Drawing.Point(622, 97);
            this.DueDateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DueDateDateTimePicker.Name = "DueDateDateTimePicker";
            this.DueDateDateTimePicker.Size = new System.Drawing.Size(228, 22);
            this.DueDateDateTimePicker.TabIndex = 34;
            // 
            // MinimumPaymentNumericUpDown
            // 
            this.MinimumPaymentNumericUpDown.Location = new System.Drawing.Point(810, 252);
            this.MinimumPaymentNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumPaymentNumericUpDown.Name = "MinimumPaymentNumericUpDown";
            this.MinimumPaymentNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.MinimumPaymentNumericUpDown.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(664, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "Minimum Payment:";
            // 
            // PaymentFrequencyNumericUpDown
            // 
            this.PaymentFrequencyNumericUpDown.Location = new System.Drawing.Point(1075, 252);
            this.PaymentFrequencyNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaymentFrequencyNumericUpDown.Name = "PaymentFrequencyNumericUpDown";
            this.PaymentFrequencyNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.PaymentFrequencyNumericUpDown.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(939, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 16);
            this.label14.TabIndex = 38;
            this.label14.Text = "Payment Frequency:";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(345, 255);
            this.amountNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.amountNumericUpDown.TabIndex = 40;
            // 
            // DebtEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1286, 532);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.PaymentFrequencyNumericUpDown);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.MinimumPaymentNumericUpDown);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DueDateDateTimePicker);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.debtTypeTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LanderNameTextBox);
            this.Controls.Add(this.interestRateNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.repaymentCollectedNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.expectedRepaymentDateDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.borrowerNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.ReceivableRadioButton);
            this.Controls.Add(this.LoanRadioButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DebtEntryForm";
            this.Text = "DebtEntryForm";
            this.Load += new System.EventHandler(this.DebtEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repaymentCollectedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestRateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumPaymentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentFrequencyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker CustomDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.RadioButton ReceivableRadioButton;
        private System.Windows.Forms.RadioButton LoanRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox borrowerNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker expectedRepaymentDateDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown repaymentCollectedNumericUpDown;
        private System.Windows.Forms.NumericUpDown interestRateNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox LanderNameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox debtTypeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DueDateDateTimePicker;
        private System.Windows.Forms.NumericUpDown MinimumPaymentNumericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown PaymentFrequencyNumericUpDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
    }
}