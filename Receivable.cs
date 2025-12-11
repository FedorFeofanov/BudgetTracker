using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class Receivable: Debt
    {
        private string BorrowerName { get; set; }
        private DateTime ExpectedRepaymentDate { get; set; }
        private bool IsInterestAccruing { get; set; }
        private double RepaymentCollected { get; set; }
        public Receivable(int iD, string landerName, double originalAmount, double currentBalance, double interestRate, DateTime startDate, string debtType, string status, string borrowerName, DateTime expectedRepaymentDate, bool isInterenstAccruing, double repaymentCollected)
            :base(iD, landerName, originalAmount, currentBalance, interestRate, startDate, debtType, status)
        { 
            BorrowerName = borrowerName;
            ExpectedRepaymentDate = expectedRepaymentDate;
            IsInterestAccruing = isInterenstAccruing;
            RepaymentCollected = repaymentCollected;
        }
    }
}
