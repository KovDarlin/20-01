using System;

class Bank
{
    public string Account { get; set; }
    public double Balance { get; set; }

    public Bank(string account, double balance)
    {
        if (string.IsNullOrWhiteSpace(account))
            throw new ArgumentException("Number account can't be empty!");
        if (balance < 0)
            throw new ArgumentException("Start balance can't be < 0!");

        Account = account;
        Balance = balance;
    }

    public void Deposit(double x)
    {
        if (x <= 0)
            throw new ArgumentException("Amount must be > 0!");
        Balance += x;
    }

    public void Withdraw(double x)
    {
        if (x <= 0)
            throw new ArgumentException("Amount must be > 0!");
        if (x > Balance)
            throw new InvalidOperationException("Not enough money, sorry!");
        Balance -= x;
    }

    public override string ToString()
    {
        return $"Account number: {Account}, Balance: {Balance}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var account = new Bank("UA1234567890", 10000);
            Console.WriteLine(account);

            account.Deposit(100);
            Console.WriteLine($"After + money: {account}");

            account.Withdraw(7000);
            Console.WriteLine($"After - money: {account}");

        }
        catch (Exception problem)
        {
            Console.WriteLine($"Error: {problem.Message}");
        }
    }
}
