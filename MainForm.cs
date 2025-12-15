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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// Go to transaction entry
        {
            TransactionEntryForm transaction = new TransactionEntryForm();
            this.Hide();
            transaction.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)// go to debt entry
        {
            DebtEntryForm debt = new DebtEntryForm();
            this.Hide();
            debt.ShowDialog();
            this.Close();
        }
    }
}
