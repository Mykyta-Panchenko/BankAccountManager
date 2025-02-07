using System;

class BankAccount
{
    public double balance;

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Withdrew {amount}. New balance: {balance}");
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
