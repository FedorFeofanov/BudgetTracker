namespace BudgetTracker
{
    partial class DebtForm
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
            this.LoansDataGridView = new System.Windows.Forms.DataGridView();
            this.Lander = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReceivablesdataGridView = new System.Windows.Forms.DataGridView();
            this.borrowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedRepaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repaymentCollected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LoansDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceivablesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LoansDataGridView
            // 
            this.LoansDataGridView.AllowUserToAddRows = false;
            this.LoansDataGridView.AllowUserToDeleteRows = false;
            this.LoansDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.LoansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoansDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lander,
            this.OriginalAmount,
            this.currentBalance,
            this.interestRate,
            this.startDate,
            this.debtType,
            this.status,
            this.dueDate,
            this.minimumPayment,
            this.paymentFrequency});
            this.LoansDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoansDataGridView.Location = new System.Drawing.Point(66, 78);
            this.LoansDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoansDataGridView.Name = "LoansDataGridView";
            this.LoansDataGridView.ReadOnly = true;
            this.LoansDataGridView.RowHeadersWidth = 51;
            this.LoansDataGridView.Size = new System.Drawing.Size(1304, 262);
            this.LoansDataGridView.TabIndex = 0;
            // 
            // Lander
            // 
            this.Lander.HeaderText = "Lander";
            this.Lander.MinimumWidth = 6;
            this.Lander.Name = "Lander";
            this.Lander.ReadOnly = true;
            this.Lander.Width = 125;
            // 
            // OriginalAmount
            // 
            this.OriginalAmount.HeaderText = "Original Amount";
            this.OriginalAmount.MinimumWidth = 6;
            this.OriginalAmount.Name = "OriginalAmount";
            this.OriginalAmount.ReadOnly = true;
            this.OriginalAmount.Width = 125;
            // 
            // currentBalance
            // 
            this.currentBalance.HeaderText = "Balance";
            this.currentBalance.MinimumWidth = 6;
            this.currentBalance.Name = "currentBalance";
            this.currentBalance.ReadOnly = true;
            this.currentBalance.Width = 125;
            // 
            // interestRate
            // 
            this.interestRate.HeaderText = "Interest Rate";
            this.interestRate.MinimumWidth = 6;
            this.interestRate.Name = "interestRate";
            this.interestRate.ReadOnly = true;
            this.interestRate.Width = 125;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "Start Date";
            this.startDate.MinimumWidth = 6;
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Width = 125;
            // 
            // debtType
            // 
            this.debtType.HeaderText = "Debt Type";
            this.debtType.MinimumWidth = 6;
            this.debtType.Name = "debtType";
            this.debtType.ReadOnly = true;
            this.debtType.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // dueDate
            // 
            this.dueDate.HeaderText = "Due Date";
            this.dueDate.MinimumWidth = 6;
            this.dueDate.Name = "dueDate";
            this.dueDate.ReadOnly = true;
            this.dueDate.Width = 125;
            // 
            // minimumPayment
            // 
            this.minimumPayment.HeaderText = "Min Payment";
            this.minimumPayment.MinimumWidth = 6;
            this.minimumPayment.Name = "minimumPayment";
            this.minimumPayment.ReadOnly = true;
            this.minimumPayment.Width = 125;
            // 
            // paymentFrequency
            // 
            this.paymentFrequency.HeaderText = "Payment Frequency";
            this.paymentFrequency.MinimumWidth = 6;
            this.paymentFrequency.Name = "paymentFrequency";
            this.paymentFrequency.ReadOnly = true;
            this.paymentFrequency.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 716);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "New loan/recievable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Loans";
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(1203, 710);
            this.homeButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(167, 34);
            this.homeButton.TabIndex = 20;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 373);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Receivables";
            // 
            // ReceivablesdataGridView
            // 
            this.ReceivablesdataGridView.AllowUserToAddRows = false;
            this.ReceivablesdataGridView.AllowUserToDeleteRows = false;
            this.ReceivablesdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ReceivablesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceivablesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowerName,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.expectedRepaymentDate,
            this.repaymentCollected});
            this.ReceivablesdataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReceivablesdataGridView.Location = new System.Drawing.Point(67, 423);
            this.ReceivablesdataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReceivablesdataGridView.Name = "ReceivablesdataGridView";
            this.ReceivablesdataGridView.ReadOnly = true;
            this.ReceivablesdataGridView.RowHeadersWidth = 51;
            this.ReceivablesdataGridView.Size = new System.Drawing.Size(1178, 262);
            this.ReceivablesdataGridView.TabIndex = 22;
            // 
            // borrowerName
            // 
            this.borrowerName.HeaderText = "Borrower Name";
            this.borrowerName.MinimumWidth = 6;
            this.borrowerName.Name = "borrowerName";
            this.borrowerName.ReadOnly = true;
            this.borrowerName.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Original Amount";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Interest Rate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Start Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Debt Type";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // expectedRepaymentDate
            // 
            this.expectedRepaymentDate.HeaderText = "Expected Repayment Date";
            this.expectedRepaymentDate.MinimumWidth = 6;
            this.expectedRepaymentDate.Name = "expectedRepaymentDate";
            this.expectedRepaymentDate.ReadOnly = true;
            this.expectedRepaymentDate.Width = 125;
            // 
            // repaymentCollected
            // 
            this.repaymentCollected.HeaderText = "Repayment Collected";
            this.repaymentCollected.MinimumWidth = 6;
            this.repaymentCollected.Name = "repaymentCollected";
            this.repaymentCollected.ReadOnly = true;
            this.repaymentCollected.Width = 125;
            // 
            // DebtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1434, 774);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.ReceivablesdataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoansDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DebtForm";
            this.Text = "DebtForm";
            ((System.ComponentModel.ISupportInitialize)(this.LoansDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceivablesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LoansDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lander;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtType;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentFrequency;
        private System.Windows.Forms.DataGridView ReceivablesdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedRepaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn repaymentCollected;
    }
}