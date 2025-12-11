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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)//go to register
        {
            Registration register = new Registration();
            register.Show();
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)//login
        {
            //здесь нужна проверка, существует ли такой аккаунт, который ввели внутри базы.

            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }
    }
}
