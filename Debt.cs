using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public abstract class Debt
    {
        public int ID;
        public string LanderName;
        public double OriginalAmount;
        public double CurrentBalance;
        public double InterestRate;
        public DateTime StartDate;
        public string DebtType;
        public string Status;

        public Debt(int iD, string landerName, double originalAmount, double currentBalance, double interestRate, DateTime startDate, string debtType, string status)
        {
            ID = iD;
            LanderName = landerName;
            OriginalAmount = originalAmount;
            CurrentBalance = currentBalance;
            InterestRate = interestRate;
            StartDate = startDate;
            DebtType = debtType;
            Status = status;
           
        }
    }
}
//everything is fine(⌐■_■)

