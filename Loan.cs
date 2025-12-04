using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class Loan: Debt
    {
        private DateTime DueDate;
        private double MinimumPayment;
        private int TermInMonths;
        private string PaymentFrequency;
    }
}
