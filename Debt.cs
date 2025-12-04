using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public abstract class Debt
    {
        private int DebtID;
        private string LanderName;
        private double OriginalAmount;
        private double CurrentBalance;
        private double InterestRate;
        private DateTime StartDate;
        private string DebtType;
        private string Status;
    }
}
