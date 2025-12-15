using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class Receivable: Debt
    {
        public string BorrowerName { get; set; }
        public DateTime ExpectedRepaymentDate { get; set; }
        public double RepaymentCollected { get; set; }
        public Receivable(int iD, string landerName, double originalAmount, double currentBalance, double interestRate, DateTime startDate, string debtType, string status, int UserID, string borrowerName, DateTime expectedRepaymentDate, bool isInterenstAccruing, double repaymentCollected)
            :base(iD, landerName, originalAmount, currentBalance, interestRate, startDate, debtType, status, UserID)
        { 
            BorrowerName = borrowerName;
            ExpectedRepaymentDate = expectedRepaymentDate;
            RepaymentCollected = repaymentCollected;
        }
    }
}
