using ConsoleApp1;
using System.Globalization;

BankAccount account = new BankAccount(21, "marcos", 10000.0);
Console.WriteLine($"The bank account number: {account.Number}, Name: {account.Name} has a balance of: R$ {account.Balance}");