using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public abstract class Transaction
    {
        private int ID {get; set;}
        private double Amount {get; set;}
        private DateTime Date {get; set;}
        private string Description {get; set;}
        private string Category {get; set;}
        private string Currency {get; set;}
        public Transaction(int iD, double amount, DateTime date, string description, string category, string currency)
        {
            ID = iD;
            Amount = amount;
            Date = date;
            Description = description;
            Category = category;
            Currency = currency;
        }
    }
}
