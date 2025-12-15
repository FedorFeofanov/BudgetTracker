using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class Income : Transaction
    {
        public bool Taxable {get; set;}
        public Income(int iD, double amount, DateTime date, string description, string category, string currency, int UserID, bool taxable)
            : base(iD, amount, date, description, category, currency, UserID)
        {
            Taxable = taxable;
        }
    }
}
