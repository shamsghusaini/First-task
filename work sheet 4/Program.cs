namespace work_sheet_4;

class Program
{
    /*
    // Task 1:
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
    
    
    // Task 2: 
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
    
    
    // Task 3: 
    static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9 / 5) + 32;
        return fahrenheit;
    }

    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double result = CelsiusToFahrenheit(celsius);

        Console.WriteLine("Temperature in Fahrenheit: " + result);
    }
   
     
    // Task 4:
    static void DisplayMenue()
    {
        Console.WriteLine("3 Option MENUE");
        Console.WriteLine("1. Start");
        Console.WriteLine("2. Help");
        Console.WriteLine("3. Exist");
    }

    static void Main()
    {
        DisplayMenue();
    }
    
    
    
    // Task 5: 
    static bool IsEven(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool result = IsEven(number);
        
        if (result)
            {
            Console.WriteLine("The number is Even");
            }
        else
            {
            Console.WriteLine("The number is Odd");
            }
    }
    */
    
    
    // Task 6:
    static double CalculateArea(double length, double width)
    {
        return  length * width;
    }

    static double CalculatePerimeter(double length, double width)
    {
        return 2 * (length + width);
    }

    static void Main()
    {
        Console.Write("Enter length: ");
        double length = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter width: ");
        double width = Convert.ToDouble(Console.ReadLine());
        
        double area = CalculateArea(length, width);
        double perimeter = CalculatePerimeter(length, width);
        
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Perimeter: " + perimeter);
    }
    
}