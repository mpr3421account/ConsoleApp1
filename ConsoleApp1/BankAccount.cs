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
            Transaction transaction = new Transaction(amount, date, observation);
            transactions.Add(transaction);
        }
        public void WithDraw(double amount, DateTime date, string observation)
        {
            Transaction transaction = new Transaction(-amount, date, observation);
            transactions.Add(transaction);
        }
    }
}
