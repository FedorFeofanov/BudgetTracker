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
    public partial class DebtForm : Form
    {
        public User user;
        public DebtForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DebtEntryForm debt = new DebtEntryForm(user: user);
            this.Hide();
            debt.ShowDialog();
            this.Close();
        }
    }
}
