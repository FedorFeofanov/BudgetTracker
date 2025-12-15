using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            RegistrationForm register = new RegistrationForm();
            this.Hide();
            register.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//login
        {
            string login = Login.Text;
            string password = Password.Text;
            foreach (User u in DataBase.Users)
            {
                if((login == u.Email ||(login == u.Name) && password == u.Password)){
                    MainForm main = new MainForm(user: u);
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Incorrect login or password. Try again.", "Login failure!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            Password.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login.Focus();
        }
    }
}
