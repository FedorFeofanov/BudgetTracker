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
    public partial class TransactionEntryForm : Form
    {
        public User user;
        public TransactionEntryForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//income
        {
            if (IncomeRadioButton.Checked)
                Merch.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//expense
        {
            if(!ExpenseRadioButton.Checked)
                Taxable.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(Amount.Text);
            if (ExpenseRadioButton.Checked)
            {
                DataBase.AddNewExpense(amount, dateTimePicker1.Value,
                  Description.Text,Category.Text,Currency.Text, user.Id, Merch.Text);
                user.CurrentBalance -= amount;
                DataBase.SaveAllData();
            }
            else if(IncomeRadioButton.Checked)
            {
                DataBase.AddNewIncome(amount, dateTimePicker1.Value,
                  Description.Text, Category.Text, Currency.Text, user.Id, Taxable.Checked);
                user.CurrentBalance += amount;
                DataBase.SaveAllData();
            }
            MainForm main = new MainForm(user: user);
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)// Return to main
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm(user: user);
            this.Hide();
            Main.ShowDialog();
            this.Close();
        }
    }
}
