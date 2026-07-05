namespace work_sheet_3;

class Program
{
    static void Main(string[] args)
    {


        // Task 1:
        Console.WriteLine("Enter the First Number:");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the Second Number:");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double positiveDifference = Math.Abs(secondNumber - firstNumber);
        Console.WriteLine("The positive difference is: " + positiveDifference);


        // Task 2: 
        Console.WriteLine("Enter Number");
        int number = int.Parse(Console.ReadLine());

        double square = Math.Pow(number, 2);
        double squareRoot = Math.Sqrt(number);

        Console.WriteLine("The square root of " + number + " is " + squareRoot);
        Console.WriteLine("The square of " + number + " is " + square);

        // Task 3: 
        Console.WriteLine("Enter Your Name");
        string name = Console.ReadLine();

        Console.WriteLine("Uppercase: " + name.ToUpper());
        Console.WriteLine("Lowercase: " + name.ToLower());
        Console.WriteLine("Number of Characters: " + name.Length);


        // Task 4:
        Console.WriteLine("Enter the number of free trial days: ");
        int days = int.Parse(Console.ReadLine());

        DateTime subscriptionStart = DateTime.Today;
        DateTime subscriptionEnd = subscriptionStart.AddDays(days);

        Console.WriteLine(" Trial End Date: " + subscriptionEnd.ToString("dd/MM/yyyy"));

        // Task 5: 
        Console.WriteLine("Enter your Exam Score:");
        double score = double.Parse(Console.ReadLine());

        double roundedScore = Math.Round(score, 2);
        Console.WriteLine("Your score is: " + roundedScore);

        if (roundedScore >= 60)
        {
            Console.WriteLine("Result: Pass");
        }
        else
        {
            Console.WriteLine("Result: Fail");
        }

        // Task 6: 
        Console.WriteLine("Enter your Password:");
        String password = Console.ReadLine();

        if (password.Length >= 8 && !password.ToLower().Contains("password"))
        {
            Console.WriteLine("Strong Password");
        }
        else
        {
            Console.WriteLine("Weak Password");
        }

        if (password.Length < 8)
        {
            Console.WriteLine("Rejected Password : must be at least 8 characters");
        }

        if (password.ToLower().Contains("password"))
        {
            Console.WriteLine("Rejected Password : must not contain the word 'password'");
        }

        // Task 7: 
        Console.WriteLine("Enter first Name: ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter second Name: ");
        string secondName = Console.ReadLine();

        firstName = firstName.Trim().ToUpper();
        secondName = secondName.Trim().ToUpper();

        if (firstName == secondName)
        {
            Console.WriteLine("Match");
        }
        else
        {
            Console.WriteLine("Not Match");
        }

        // Task 8: 
        try 
        {
        Console.WriteLine("Enter the membership start date (yyyy/MM/dd): ");
        DateTime startdate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter the membership days: ");
        int membershipdays = int.Parse(Console.ReadLine());

        DateTime expiryDate = startdate.AddDays(membershipdays);
        if (expiryDate >= DateTime.Today)
        {
            Console.WriteLine("Membership status: Active");
        }
        else
        {
            Console.WriteLine("Membership status: Expired");
        }

        Console.WriteLine("Expiry date: " + expiryDate.ToString("dd/MM/yyyy"));
         }
        catch
            {
            Console.WriteLine("Invalid Input");
            }
        
        
        // Task 9:
        Console.WriteLine("Enter a decimal number: ");
        double decimalNumber = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Rounded:  " + Math.Round (decimalNumber));
        Console.WriteLine("Rounded up:  " + Math.Ceiling(decimalNumber));
        Console.WriteLine("Rounded Down:  " + Math.Floor(decimalNumber));
    }
}