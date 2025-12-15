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
        public TransactionEntryForm()
        {
            InitializeComponent();
        }

        int ID = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//income
        {
            if (radioButton1.Checked)
                Merch.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//expense
        {
            if(!radioButton2.Checked)
                Taxable.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
;                DataBase.AddNewExpense(double.Parse(Amount.Text), dateTimePicker1.Value,
                 Description.Text,Category.Text,Currency.Text,Merch.Text);
            }
            else if(radioButton2.Checked)
            {
                DataBase.AddNewIncome(double.Parse(Amount.Text), dateTimePicker1.Value,
                Description.Text, Category.Text, Currency.Text, Taxable.Checked);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransactionEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)// Return to main
        {
            MainForm Main = new MainForm();
            this.Hide();
            Main.ShowDialog();
            this.Close();


        }
    }
}
