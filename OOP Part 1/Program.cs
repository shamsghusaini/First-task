namespace OOP_Part_1;


    class BankAccount
        {
    public int AccountNumber;
    public string HolderName;
    public double Balance;

    public void Deposit(double amount)
    {
        Balance += amount;
        SendEmail();
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            SendEmail();
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }

    public double CheckBalance()
    {
        PrintInformation();
        return Balance;
    }

    private void PrintInformation()
    {
        Console.WriteLine($"Name: {HolderName}");
        Console.WriteLine($"Balance: {Balance}");
    }

    private void SendEmail()
    {
        Console.WriteLine("Email notification sent.");
    }
}
    
