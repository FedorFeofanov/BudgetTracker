using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public abstract class Transaction
    {
        public int ID {get; set;}
        public double Amount {get; set;}
        public DateTime Date {get; set;}
        public string Description {get; set;}
        public string Category {get; set;}
        public string Currency {get; set;}
        public int UserID {get; set;}
        public Transaction(int iD, double amount, DateTime date, string description, string category, string currency, int userID)
        {
            ID = iD;
            Amount = amount;
            Date = date;
            Description = description;
            Category = category;
            Currency = currency;
            UserID = userID;
        }
    }
}
