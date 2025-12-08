using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace BudgetTracker
{
    internal class DataBase
    {
        public static Dictionary<int, Receivable> Receivables = new Dictionary<int, Receivable>();
        private static readonly string ReceivablesFile = "receivables.json";

        public static Dictionary<int, Loan> Loans = new Dictionary<int, Loan>();
        private static readonly string LoansFile = "loans.json";

        public static Dictionary<int, Income> Incomes = new Dictionary<int, Income>();
        private static readonly string IncomesFile = "incomes.json";

        public static Dictionary<int, Expense> Expenses = new Dictionary<int, Expense>();
        private static readonly string ExpensesFile = "expenses.json";

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
            Receivables = Read<Dictionary<int, Receivable>>(ReceivablesFile);
            Loans = Read<Dictionary<int, Loan>>(LoansFile);
            Incomes = Read<Dictionary<int, Income>>(IncomesFile);
            Expenses = Read<Dictionary<int, Expense>>(ExpensesFile);
        }

        public static void SaveAllData()
        {
            Save(Receivables, ReceivablesFile);
            Save(Loans, LoansFile);
            Save(Incomes, IncomesFile);
            Save(Expenses, ExpensesFile);
        }
    }
}