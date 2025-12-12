using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class Expense: Transaction
    {
        public string MerchantName {get; set;}
        public Expense(int iD, double amount, DateTime date, string description, string category, string currency, string merchantName)
            : base(iD, amount, date, description, category, currency)
        {
            MerchantName = merchantName;
        }
    }
}
