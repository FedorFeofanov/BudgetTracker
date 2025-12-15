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


            if(radioButton1.Checked)
            {
;                DataBase.AddNewLoan(double.Parse(Amount.Text), dateTimePicker1.Value,
                 Description.Text);//
            }
            else if(radioButton2.Checked)
            {
                DataBase.AddNewReceivable(double.Parse(Amount.Text), dateTimePicker1.Value,
                Description.Text);//нужно будет создать для формы поля ввода и спарсить сюда потом
            }
            //function required

            DebtForm debt = new DebtForm();
            this.Hide();
            debt.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//Return to main page
        {
            MainForm Main = new MainForm();
            this.Hide();
            Main.ShowDialog();
            this.Close();

            
        }
    }
}
