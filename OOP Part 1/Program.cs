namespace OOP_Part_1;
using System;

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

class Program
{
    static void Main(string[] args)
    {
        BankAccount account1 = new BankAccount();
        account1.AccountNumber = 1163;
        account1.HolderName = "Shams";
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
                    Console.WriteLine("Choose an account:");
                    Console.WriteLine("1. Shams");
                    Console.WriteLine("2. Ali");

                    int accountChoice = int.Parse(Console.ReadLine());

                    if (accountChoice == 1)
                    {
                        account1.CheckBalance();
                    }
                    else if (accountChoice == 2)
                    {
                        account2.CheckBalance();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }

                    break;
                
                case 2:
                    Console.WriteLine("Choose a student:");
                    Console.WriteLine("1. Ali");
                    Console.WriteLine("2. Ahmed");

                    int studentChoice = int.Parse(Console.ReadLine());

                    Console.Write("Enter the new address: ");
                    string newAddress = Console.ReadLine();

                    if (studentChoice == 1)
                    {
                        student1.Address = newAddress;
                        Console.WriteLine($"Ali's new address is: {student1.Address}");
                    }
                    else if (studentChoice == 2)
                    {
                        student2.Address = newAddress;
                        Console.WriteLine($"Ahmed's new address is: {student2.Address}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }

                    break;
                
                case 3:
                    Console.WriteLine("Choose an account:");
                    Console.WriteLine("1. Shams");
                    Console.WriteLine("2. Ali");

                    int depositChoice = int.Parse(Console.ReadLine());

                    Console.Write("Enter the amount to deposit: ");
                    double amount = double.Parse(Console.ReadLine());

                    if (depositChoice == 1)
                    {
                        account1.Deposit(amount);
                        Console.WriteLine($"{account1.HolderName}'s new balance is: {account1.Balance}");
                    }
                    else if (depositChoice == 2)
                    {
                        account2.Deposit(amount);
                        Console.WriteLine($"{account2.HolderName}'s new balance is: {account2.Balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }

                    break;
                
                case 4:
                    Console.WriteLine("Choose an account:");
                    Console.WriteLine("1. Shams");
                    Console.WriteLine("2. Ali");

                    int withdrawChoice = int.Parse(Console.ReadLine());

                    Console.Write("Enter the amount to withdraw: ");
                    double withdrawAmount = double.Parse(Console.ReadLine());

                    if (withdrawChoice == 1)
                    {
                        account1.Withdraw(withdrawAmount);
                        Console.WriteLine($"{account1.HolderName}'s new balance is: {account1.Balance}");
                    }
                    else if (withdrawChoice == 2)
                    {
                        account2.Withdraw(withdrawAmount);
                        Console.WriteLine($"{account2.HolderName}'s new balance is: {account2.Balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                    
                    break;
                case 5:
                    Console.WriteLine("Choose a product:");
                    Console.WriteLine("1. Wireless Mouse");
                    Console.WriteLine("2. Mechanical Keyboard");

                    int productChoice = int.Parse(Console.ReadLine());

                    if (productChoice == 1)
                    {
                        double value = product1.GetInventoryValue();
                        Console.WriteLine($"Inventory Value: {value}");
                    }
                    else if (productChoice == 2)
                    {
                        double value = product2.GetInventoryValue();
                        Console.WriteLine($"Inventory Value: {value}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }

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
    }
}
    


    
