using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
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
        public static User AddNewUser(string name, string email, string password)
        {

            foreach (User u in Users)
            {
                if (u.Email == email)
                {
                    return null;
                }
            }

            User user = new User(GetNextIdUser(), name, email, password);
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
    }
}