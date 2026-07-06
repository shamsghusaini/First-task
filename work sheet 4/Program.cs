namespace work_sheet_4;

class Program
{
    /*
    static void PrintWelcome(string name)
    {
        Console.WriteLine("Welcome " + name);
        Console.WriteLine("We hope you enjoy learning");
    }

    static void Main()
    {
        Console.WriteLine("Enter your Name: ");
        string name = Console.ReadLine();
        PrintWelcome(name);
    }
*/
    static int Square(int number)
    {
        return number * number;
    }

    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int result = Square(number);
        Console.WriteLine("The square is " + result);
    }
}