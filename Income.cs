using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class Income : Transaction
    {
        private string SourceOfIncome {get; set;}
        private bool Taxable {get; set;}
        public Income(int iD, double amount, DateTime date, string description, string category, string currency, string sourceOfIncome, bool taxable)
            : base(iD, amount, date, description, category, currency)
        {
            SourceOfIncome = sourceOfIncome;
            Taxable = taxable;
        }
    }
}
