using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class Loan : Debt
    {
        private DateTime DueDate { get; set; }
        private double MinimumPayment { get; set; }
        private int TermInMonths { get; set; }
        private string PaymentFrequency { get; set; }
        public Loan(int iD, string landerName, double originalAmount, double currentBalance, double interestRate, DateTime startDate, string debtType, string status, DateTime dueDate, double minimumPayment, int termInMonths, string paymentFrequency)
            :base(iD, landerName, originalAmount, currentBalance, interestRate, startDate, debtType, status)
        {
            DueDate = dueDate;
            MinimumPayment = minimumPayment;
            TermInMonths = termInMonths;
            PaymentFrequency = paymentFrequency;
        }
    }
}
