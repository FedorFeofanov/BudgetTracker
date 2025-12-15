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
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.ReceivableRadioButton = new System.Windows.Forms.RadioButton();
            this.LoanRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(81, 256);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 17;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Custom date ";
            // 
            // CustomDateTimePicker
            // 
            this.CustomDateTimePicker.Location = new System.Drawing.Point(81, 219);
            this.CustomDateTimePicker.Name = "CustomDateTimePicker";
            this.CustomDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.CustomDateTimePicker.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Amount";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(224, 166);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(222, 20);
            this.DescriptionTextBox.TabIndex = 12;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(94, 166);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountTextBox.TabIndex = 11;
            // 
            // ReceivableRadioButton
            // 
            this.ReceivableRadioButton.AutoSize = true;
            this.ReceivableRadioButton.Location = new System.Drawing.Point(81, 99);
            this.ReceivableRadioButton.Name = "ReceivableRadioButton";
            this.ReceivableRadioButton.Size = new System.Drawing.Size(79, 17);
            this.ReceivableRadioButton.TabIndex = 10;
            this.ReceivableRadioButton.TabStop = true;
            this.ReceivableRadioButton.Text = "Receivable";
            this.ReceivableRadioButton.UseVisualStyleBackColor = true;
            // 
            // LoanRadioButton
            // 
            this.LoanRadioButton.AutoSize = true;
            this.LoanRadioButton.Location = new System.Drawing.Point(81, 68);
            this.LoanRadioButton.Name = "LoanRadioButton";
            this.LoanRadioButton.Size = new System.Drawing.Size(49, 17);
            this.LoanRadioButton.TabIndex = 9;
            this.LoanRadioButton.TabStop = true;
            this.LoanRadioButton.Text = "Loan";
            this.LoanRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Register new debt";
            // 
            // DebtEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(550, 379);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.ReceivableRadioButton);
            this.Controls.Add(this.LoanRadioButton);
            this.Name = "DebtEntryForm";
            this.Text = "DebtEntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker CustomDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.RadioButton ReceivableRadioButton;
        private System.Windows.Forms.RadioButton LoanRadioButton;
        private System.Windows.Forms.Label label4;
    }
}