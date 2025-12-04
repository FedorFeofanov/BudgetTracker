using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public abstract class Transaction
    {
        private int ID;
        private double Amount;
        private DateTime Date;
        private string Description;
        private string Category;
        private string Currency;
    }
}
