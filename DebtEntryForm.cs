using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class DebtEntryForm : Form
    {
        public User user;
        public DebtEntryForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)//submit button
        {
            double amount = decimal.ToDouble(amountNumericUpDown.Value);
            string description = descriptionTextBox.Text;
            string status = statusTextBox.Text;
            string debtType = debtTypeTextBox.Text;
            double interestRate = decimal.ToDouble(interestRateNumericUpDown.Value);
            DateTime startDate = CustomDateTimePicker.Value;

            if (LoanRadioButton.Checked)
            {
                string landerName = LanderNameTextBox.Text;
                DateTime dueDate = DueDateDateTimePicker.Value;
                double minimumPayment = decimal.ToDouble(MinimumPaymentNumericUpDown.Value);
                double paymentFrequency = decimal.ToDouble(PaymentFrequencyNumericUpDown.Value);
                DataBase.AddNewLoan(landerName: landerName, originalAmount: amount, currentBalance: amount, interestRate: interestRate, startDate: startDate,
                    debtType: debtType, status: status, UserID: user.Id, dueDate: dueDate, minimumPayment: minimumPayment, paymentFrequency: paymentFrequency);
            }
            else if (ReceivableRadioButton.Checked)
            {
                string borrowerName = borrowerNameTextBox.Text;
                DateTime expectedRepaymentDate = expectedRepaymentDateDateTimePicker.Value;
                double repaymetCollected = decimal.ToDouble(repaymentCollectedNumericUpDown.Value);
                DataBase.AddNewReceivable(landerName: user.Name, originalAmount: amount, interestRate: interestRate, currentBalance: amount, startDate: startDate,
                    debtType: debtType, status: status, UserID: user.Id, borrowerName: borrowerName, expectedRepaymentDate: expectedRepaymentDate, 
                    repaymentCollected: repaymetCollected);
            }

            DebtForm debt = new DebtForm(user: user);
            this.Hide();
            debt.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//Return to main page
        {
            MainForm Main = new MainForm(user: user);
            this.Hide();
            Main.ShowDialog();
            this.Close();


        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            DebtForm debt = new DebtForm(user: user);
            this.Hide();
            debt.ShowDialog();
            this.Close();
        }
        private void DebtEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}