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
    public partial class DebtForm : Form
    {
        public User user;
        public DebtForm(User user)
        {
            InitializeComponent();
            this.user = user;
            foreach(Loan loan in DataBase.Loans)
            {
                LoansDataGridView.Rows.Add(loan.ID,loan.LanderName, loan.OriginalAmount, loan.CurrentBalance, loan.InterestRate, loan.StartDate, loan.DebtType, loan.Status,
                    loan.DueDate, loan.MinimumPayment, loan.PaymentFrequency);
            }
            foreach(Receivable receivable in DataBase.Receivables)
            {
                LoansDataGridView.Rows.Add(receivable.ID,receivable.BorrowerName, receivable.OriginalAmount, receivable.CurrentBalance, receivable.InterestRate, receivable.StartDate, 
                    receivable.DebtType, receivable.Status, receivable.ExpectedRepaymentDate, receivable.RepaymentCollected);
            }
        }

        private void RefreshGrids()//refresh
        {
            LoansDataGridView.Rows.Clear();
            ReceivablesdataGridView.Rows.Clear();

            foreach (Loan loan in DataBase.Loans)
            {
                LoansDataGridView.Rows.Add(loan.ID, loan.LanderName, loan.OriginalAmount, loan.CurrentBalance,
                    loan.InterestRate, loan.StartDate, loan.DebtType, loan.Status,
                    loan.DueDate, loan.MinimumPayment, loan.PaymentFrequency);
            }

            foreach (Receivable receivable in DataBase.Receivables)
            {
                LoansDataGridView.Rows.Add(receivable.ID, receivable.BorrowerName, receivable.OriginalAmount, receivable.CurrentBalance, receivable.InterestRate, receivable.StartDate,
                    receivable.DebtType, receivable.Status, receivable.ExpectedRepaymentDate, receivable.RepaymentCollected);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DebtEntryForm debt = new DebtEntryForm(user: user);
            this.Hide();
            debt.ShowDialog();
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(user: user);
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void LoansDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//Loans
        {
            if (LoansDataGridView.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(LoansDataGridView.SelectedRows[0].Cells[0].Value);
                DataBase.DeleteLoan(id);
                RefreshGrids();
            }
        }

        private void button3_Click(object sender, EventArgs e)//Receivable
        {
            if(ReceivablesdataGridView.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(LoansDataGridView.SelectedRows[0].Cells[0].Value);
                DataBase.DeleteReceivable(id);
                RefreshGrids();
            }
        }

        private void DebtForm_Load(object sender, EventArgs e)
        {
            ReceivablesdataGridView.MultiSelect = false;
            LoansDataGridView.MultiSelect = false;
        }
    }
}
