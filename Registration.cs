using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            
            string email = Email.Text;
            if (String.IsNullOrEmpty(email))
            {
            MessageBox.Show("Email field cannot be empty. Try again.","Critical failure!",
            MessageBoxButtons.OK,MessageBoxIcon.Error);
            return;
            }
            string name = Name.Text;
            if (String.IsNullOrEmpty(name))
            {
            MessageBox.Show("Name field cannot be empty. Try again.","Critical failure!",
            MessageBoxButtons.OK,MessageBoxIcon.Error);
            return;
            }
            string password = Password.Text;
            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Login field cannot be empty. Try again.", "Critical failure!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = DataBase.AddNewUser(email, name, password);
            MessageBox.Show("User created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (user == null)
            {
                MessageBox.Show("Email is already in use. Try again.", "Registration failure!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            Name.Focus();   
        }
    }
}
