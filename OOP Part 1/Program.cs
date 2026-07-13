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
class Student
{
    public int Grade;
    public string Name;
    public string Address;

    private string email;
    int age;

    public void Register(string Email)
    {
        email = Email;
        SendEmail();
    }

    private void SendEmail()
    {
        Console.WriteLine("Registration email sent.");
    }
}
class Product
{
    public string ProductName;
    public double Price;
    public int StockQuantity;

    public void Sell(int quantity)
    {
        if (StockQuantity >= quantity)
        {
            StockQuantity -= quantity;
        }
        else
        {
            Console.WriteLine("Not enough stock.");
        }

        LogTransaction();
    }

    public void Restock(int quantity)
    {
        StockQuantity += quantity;
        LogTransaction();
    }

    public double GetInventoryValue()
    {
        PrintDetails();
        return Price * StockQuantity;
    }

    private void PrintDetails()
    {
        Console.WriteLine($"Product: {ProductName}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Stock: {StockQuantity}");
    }

    private void LogTransaction()
    {
        Console.WriteLine("Transaction logged.");
    }
}
BankAccount account1 = new BankAccount();
account1.AccountNumber = 1163;
account1.HolderName = "Karim";
account1.Balance = 120;

BankAccount account2 = new BankAccount();
account2.AccountNumber = 15203;
account2.HolderName = "Ali";
account2.Balance = 63;

Student student1 = new Student();
student1.Name = "Ali";
student1.Address = "Muscat";
student1.Grade = 65;

Student student2 = new Student();
student2.Name = "Ahmed";
student2.Address = "Muscat";
student2.Grade = 70;

Product product1 = new Product();
product1.ProductName = "Wireless Mouse";
product1.Price = 5.500;
product1.StockQuantity = 50;

Product product2 = new Product();
product2.ProductName = "Mechanical Keyboard";
product2.Price = 15.750;
product2.StockQuantity = 20;

int choice;

do
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1. View Account Details");
    Console.WriteLine("2. Update Student Address");
    Console.WriteLine("3. Make Deposit");
    Console.WriteLine("4. Make Withdrawal");
    Console.WriteLine("5. View Product Details");
    Console.WriteLine("6. Register Student");
    Console.WriteLine("7. Compare Account Balances");
    Console.WriteLine("8. Restock Product");
    Console.WriteLine("9. Transfer Between Accounts");
    Console.WriteLine("10. Update Student Grade");
    Console.WriteLine("11. Student Report Card");
    Console.WriteLine("12. Account Health Status");
    Console.WriteLine("13. Bulk Sale");
    Console.WriteLine("14. Scholarship Eligibility");
    Console.WriteLine("15. Full Balance Top-Up");
    Console.WriteLine("20. Exit");

    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            account1.CheckBalance();
            break;

        case 7:
            if (account1.Balance > account2.Balance)
                Console.WriteLine($"{account1.HolderName} has more money.");
            else if (account2.Balance > account1.Balance)
                Console.WriteLine($"{account2.HolderName} has more money.");
            else
                Console.WriteLine("Both accounts are equal.");
            break;

        case 20:
            Console.WriteLine("Goodbye!");
            break;
    }

} while (choice != 20);

    
