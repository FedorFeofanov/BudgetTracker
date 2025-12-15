using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class Loan : Debt
    {
        public DateTime DueDate { get; set; }
        public double MinimumPayment { get; set; }
        public string PaymentFrequency { get; set; }
        public Loan(int iD, string landerName, double originalAmount, double currentBalance, double interestRate, DateTime startDate, string debtType, string status, int UserID, DateTime dueDate, double minimumPayment, string paymentFrequency)
            :base(iD, landerName, originalAmount, currentBalance, interestRate, startDate, debtType, status, UserID)
        {
            DueDate = dueDate;
            MinimumPayment = minimumPayment;
            PaymentFrequency = paymentFrequency;
        }
    }
}
