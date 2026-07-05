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
        Console.WriteLine("The square of " + number + " is " + squareRoot);
        
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
        
        
        
    }
}