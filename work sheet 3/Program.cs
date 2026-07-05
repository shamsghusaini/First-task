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
        Console.WriteLine(" Enter Number");
        int number = int.Parse(Console.ReadLine());
        
        double square = Math.Pow(number, 2);
        double squareRoot = Math.Sqrt(number);
        
        Console.WriteLine("The square root of " + number + " is " + squareRoot);
        Console.WriteLine("The square of " + number + " is " + squareRoot);
        
        
        
        
    }
}