namespace work_sheet_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        // Task 1:
        Console.WriteLine("Enter the First Number:");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the Second Number:");
        double secondNumber = Convert.ToDouble(Console.ReadLine());
        
        double positiveDifference = Math.Abs(secondNumber - firstNumber);
        Console.WriteLine("The positive difference is: " + positiveDifference);
        
        
        
        
    }
}