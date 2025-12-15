using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class MainForm : Form
    {
        public User user;
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
            CurrentBalanceTextBox.Text = user.CurrentBalance.ToString();
            foreach(Income i in DataBase.Incomes)
            {
                TransactionsDataGridView.Rows.Add(i.Amount, i.Date, i.Description, i.Category, i.Currency);
            }
            foreach(Expense e in DataBase.Expenses)
            {
                TransactionsDataGridView.Rows.Add(-e.Amount, e.Date, e.Description, e.Category, e.Currency);
            }
        }

        private void button1_Click(object sender, EventArgs e)// Go to transaction entry
        {
            TransactionEntryForm transaction = new TransactionEntryForm(user: user);
            this.Hide();
            transaction.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)// go to debt entry
        {
            DebtEntryForm debt = new DebtEntryForm(user: user);
            this.Hide();
            debt.ShowDialog();
            this.Close();
        }
    }
}
