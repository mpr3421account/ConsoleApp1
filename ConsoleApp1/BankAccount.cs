using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ConsoleApp1
{
    internal class BankAccount
    {
        List<Transaction> transactions = new List<Transaction>();

        public int Number { get; private set; }
        public string Name { get; set; }
        
        public double Balance
        {
            get 
            {
                double balance = 0;
                foreach (var item in transactions)
                {
                    balance += item.Value;
                }
                return balance;
            }
        }

        public BankAccount(int number, string name, double balance)
        {
            Number = number;
            Name = name;
            Deposit(balance, DateTime.Now, "Inicial Balance");
        }

        public void Deposit(double amount, DateTime date, string observation)
        {
            if(amount < 0)
            {
                throw new Exception("We can't accept negative values or zero.");
            }
            Transaction transaction = new Transaction(amount, date, observation);
            transactions.Add(transaction);
        }
        public void WithDraw(double amount, DateTime date, string observation)
        {
            if (amount < 0)
            {
                throw new Exception("We can't accept negative values or zero.");
            }
            Transaction transaction = new Transaction(-amount, date, observation);
            transactions.Add(transaction);
        }
        public string TakeTransactions()
        {
            var resumeTransactions = new StringBuilder();
            resumeTransactions.AppendLine("Date\t\tValue\tObservation");
            foreach(var item in transactions)
            {
                resumeTransactions.AppendLine($"{item.Date.ToShortDateString()}\t{item.Value}\t{item.Observation}");
            }
            return resumeTransactions.ToString();
        }
        
    }
}
