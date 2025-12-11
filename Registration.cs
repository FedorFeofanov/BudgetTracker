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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            
            string login = Login.Text;
            if (String.IsNullOrEmpty(login))
            {
            MessageBox.Show("Login field cannot be empty. Try again.","Critical failure!",
            MessageBoxButtons.OK,MessageBoxIcon.Error);
                Login.Clear();
                Password.Clear();
            return;
            }
            string password = Password.Text;
            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Login field cannot be empty. Try again.", "Critical failure!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Login.Clear();
                Password.Clear();
                return;
            }

            

            //User user = new User(login, password); В валидацию накинуть надо еще проверку, нет ли такого объекта в JSON, + добавить добавление 
            // объекта в JSON.
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
