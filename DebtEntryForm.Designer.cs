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
            this.Description = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
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
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(348, 207);
            this.Description.Margin = new System.Windows.Forms.Padding(4);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(295, 22);
            this.Description.TabIndex = 12;
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(181, 207);
            this.Amount.Margin = new System.Windows.Forms.Padding(4);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(132, 22);
            this.Amount.TabIndex = 11;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(197, 119);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 20);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Recivable";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(197, 69);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 20);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Loan";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(917, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 45);
            this.button2.TabIndex = 18;
            this.button2.Text = "🏠︎";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DebtEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(550, 379);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.ReceivableRadioButton);
            this.Controls.Add(this.LoanRadioButton);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button button2;
    }
}