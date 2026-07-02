namespace work_sheet_2;

class Program
{
    static void Main(string[] args)
    {
        //Task 1
        Console.WriteLine("Enter a number:");
        int number =  int.Parse(Console.ReadLine());

        for ( int i = number; i >= 1; i--)
        {
          Console.WriteLine(i);  
        }

        Console.WriteLine("Liftoff");
    }
}