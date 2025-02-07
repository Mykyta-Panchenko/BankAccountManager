using System;

public class BankAccount
{
    private double _balance;

    public double Balance => _balance;

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }

        _balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {_balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount > _balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        _balance -= amount;
        Console.WriteLine($"Withdrew {amount}. New balance: {_balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.Deposit(100);
        account.Withdraw(50);
        account.Withdraw(70);
    }
}
