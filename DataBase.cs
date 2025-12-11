using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

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
    }
}