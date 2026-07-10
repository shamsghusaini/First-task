using System;
using System.Collections.Generic;

namespace First_Project;

class Program
{
    static List<string> customerNames = new List<string>();
    static List<string> accountNumbers = new List<string>();
    static List<double> balances = new List<double>();

    static void Main(string[] args)
    {
        bool exitApp = false;

        while (!exitApp)
        {
            Console.WriteLine("\n===== Welcome to Spark Bank =====");
            Console.WriteLine("1. Add New Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Show Balance");
            Console.WriteLine("5. Transfer Amount");
            Console.WriteLine("6. Custom Service");
            Console.WriteLine("7. Custom Service");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");

            int choice;

            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddAccount();
                    break;

                case 8:
                    exitApp = true;
                    Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                    break;

                default:
                    Console.WriteLine("This option is not implemented yet.");
                    break;
            }
        }
    }

    static void AddAccount()
    {
        Console.Write("Enter customer name: ");
        string name = Console.ReadLine();

        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();

        if (accountNumbers.Contains(accountNumber))
        {
            Console.WriteLine("Account number already exists.");
            return;
        }

        Console.Write("Enter starting balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());

        if (balance < 0)
        {
            Console.WriteLine("Balance cannot be negative.");
            return;
        }

        customerNames.Add(name);
        accountNumbers.Add(accountNumber);
        balances.Add(balance);

        Console.WriteLine("\nAccount created successfully!");
        Console.WriteLine($"Customer Name: {name}");
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Balance: {balance}");
    }
}