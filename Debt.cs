using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public abstract class Debt
    {
        private int ID;
        private string LanderName;
        private double OriginalAmount;
        private double CurrentBalance;
        private double InterestRate;
        private DateTime StartDate;
        private string DebtType;
        private string Status;

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
