using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Mail;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BudgetTracker
{
    internal class DataBase
    {
        public static List<Receivable> Receivables = new List<Receivable>();
        private static readonly string ReceivablesFile = "receivables.json";

        public static List<Loan> Loans = new List<Loan>();
        private static readonly string LoansFile = "loans.json";

        public static List<Income> Incomes = new List<Income>();
        private static readonly string IncomesFile = "incomes.json";

        public static List<Expense> Expenses = new List<Expense>();
        private static readonly string ExpensesFile = "expenses.json";

        public static List<User> Users = new List<User>();
        private static readonly string UsersFile = "users.json";


        static DataBase()
        {
            LoadAllData();
        }

        public static void Save<T>(T data, string file)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(file, json);
        }

        public static T Read<T>(string file) where T : new()
        {
            if (!File.Exists(file))
            {
                return new T();
            }

            string json = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static void LoadAllData()
        {
            Receivables = Read<List<Receivable>>(ReceivablesFile);
            Loans = Read<List<Loan>>(LoansFile);
            Incomes = Read<List<Income>>(IncomesFile);
            Expenses = Read<List<Expense>>(ExpensesFile);
            Users = Read<List<User>>(UsersFile);
        }

        public static void SaveAllData()
        {
            Save(Receivables, ReceivablesFile);
            Save(Loans, LoansFile);
            Save(Incomes, IncomesFile);
            Save(Expenses, ExpensesFile);
            Save(Users, UsersFile);
        }
        public static int GetNextIdUser()
        {
            if (Users == null || Users.Count == 0)
            {
                return 1; 
            }
            int maxId = 0;
            foreach (User user in Users)
            {
                int currentId = user.Id;
                if (currentId > maxId)
                {
                    maxId = currentId;
                }
            }
            return maxId + 1;
        }
        public static User AddNewUser(string name, string email, string password, double currentBalance)
        {

            foreach (User u in Users)
            {
                if (u.Email == email)
                {
                    return null;
                }
            }

            User user = new User(id: GetNextIdUser(), name: name, email: email, password: password, currentBalance: currentBalance);
            Users.Add(user);
            SaveAllData();
            return user;
        }
        public static int GetNextIdLoan()
        {
            if (Loans == null || Loans.Count == 0)
            {
                return 1; 
            }
            int maxId = 0;
            foreach (Loan loan in Loans)
            {
                int currentId = loan.ID;
                if (currentId > maxId)
                {
                    maxId = currentId;
                }
            }
            return maxId + 1;
        }
        public static Loan AddNewLoan(string landerName, double originalAmount, double currentBalance, double interestRate, DateTime startDate, string debtType, string status, int UserID, DateTime dueDate, double minimumPayment, int termInMonths, string paymentFrequency)
        {
            int iD = GetNextIdLoan();
            Loan loan = new Loan(iD, landerName, originalAmount, currentBalance, interestRate, startDate, debtType, status, UserID, dueDate, minimumPayment, paymentFrequency);
            Loans.Add(loan);
            SaveAllData();
            return loan;
        }
        public static int GetNextIdReceivable()
        {
            if (Receivables == null || Receivables.Count == 0)
            {
                return 1; 
            }
            int maxId = 0;
            foreach (Receivable receivable in Receivables)
            {
                int currentId = receivable.ID;
                if (currentId > maxId)
                {
                    maxId = currentId;
                }
            }
            return maxId + 1;
        }
        public static Receivable AddNewReceivable(string landerName, double originalAmount, double currentBalance, double interestRate, DateTime startDate, string debtType, string status, int UserID, string borrowerName, DateTime expectedRepaymentDate, double repaymentCollected)
        {
            int iD = GetNextIdReceivable();
            Receivable recievable = new Receivable(iD, landerName, originalAmount, currentBalance, interestRate, startDate, debtType, status, UserID, borrowerName, expectedRepaymentDate, repaymentCollected);
            Receivables.Add(recievable);
            SaveAllData();
            return recievable;
        }
        public static int GetNextIdIncome()
        {
            if (Incomes == null || Incomes.Count == 0)
            {
                return 1; 
            }
            int maxId = 0;
            foreach (Income income in Incomes)
            {
                int currentId = income.ID;
                if (currentId > maxId)
                {
                    maxId = currentId;
                }
            }
            return maxId + 1;
        }
        public static Income AddNewIncome(double amount, DateTime date, string description, string category, string currency, int UserID, bool taxable)
        {
            int iD = GetNextIdIncome();
            Income income = new Income(iD, amount, date, description, category, currency, UserID, taxable);
            Incomes.Add(income);
            SaveAllData();
            return income;
        }
        public static int GetNextIdExpense()
        {
            if (Expenses == null || Expenses.Count == 0)
            {
                return 1; 
            }
            int maxId = 0;
            foreach (Expense expense in Expenses)
            {
                int currentId = expense.ID;
                if (currentId > maxId)
                {
                    maxId = currentId;
                }
            }
            return maxId + 1;
        }
        public static Expense AddNewExpense(double amount, DateTime date, string description, string category, string currency, int UserID, string merchantName)
        {
            int iD = GetNextIdExpense();
            Expense expense = new Expense(iD, amount, date, description, category, currency, UserID, merchantName);
            Expenses.Add(expense);
            SaveAllData();
            return expense;
        }
    }
}