using ConsoleApp1;
using System.Globalization;

BankAccount account = new BankAccount(21, "marcos", 10000.0);
Console.WriteLine($"The bank account number: {account.Number}, Name: {account.Name} has a balance of: R$ {account.Balance}");
try
{
    account.Deposit(-100.0, DateTime.Now, "Payment Received");
    Console.WriteLine($"The account is now with the amount of: R${account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");

    account.WithDraw(500.0, DateTime.Now, "Valor Sacado");
    Console.WriteLine($"The account is now with the amount of: R${account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
}
catch (Exception e)
{
    Console.WriteLine($"An error occurred! {e.Message}");
}

account.Deposit(5000.0, DateTime.Now, "Payment Received");
Console.WriteLine($"The account is now with the amount of: R${account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");

account.WithDraw(500.0, DateTime.Now, "Valor Sacado");
Console.WriteLine($"The account is now with the amount of: R${account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");

Console.WriteLine(account.TakeTransactions());