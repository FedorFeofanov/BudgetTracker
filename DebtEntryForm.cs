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

        private void button1_Click(object sender, EventArgs e)
        {
            if(LoanRadioButton.Checked)
            {
                //DataBase.AddNewLoan();
            }
            else if(ReceivableRadioButton.Checked)
            {
                //DataBase.AddNewReceivable();
            }
        }
    }
}
