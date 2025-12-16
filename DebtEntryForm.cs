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


            if (LoanRadioButton.Checked)
            {
;                //DataBase.AddNewLoan(double.Parse(AmountTextBox.Text), CustomDateTimePicker.Value,
                 //DescriptionTextBox.Text);
            }
            else if (ReceivableRadioButton.Checked)
            {
                //DataBase.AddNewReceivable(double.Parse(AmountTextBox.Text), CustomDateTimePicker.Value,
                //DescriptionTextBox.Text);//нужно будет создать для формы поля ввода и спарсить сюда потом
            }
            //function required

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
    }
}