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
    
    
    // Task 7: 
    static string GetGradeLetter(int score)
    {
        if (score >= 90)
        {
            return "A";
        }
        else if (score >= 80)
        {
            return "B";
        }
        else if (score >= 70)
        {
            return "C";
        }
        else if (score >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }

    static void Main()
    {
        Console.Write("Enter your score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        string grade = GetGradeLetter(score);
        Console.WriteLine("your grade is " + grade);
    }
        
    
    
    
    
    // Task 8: 
    static void Countdown(int number)
    {
        for (int i = number; i > 0; i--)
        {
            Console.WriteLine(i);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter a starting number ");
        int number = Convert.ToInt32(Console.ReadLine());
        Countdown(number);
    }
    
    
    
    // Task 9 : 
    // Multiply two integers
    static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    // Multiply two doubles
    static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    // Multiply three integers
    static int Multiply(int num1, int num2, int num3)
    {
        return num1 * num2 * num3;
    }

    static void Main()
    {
        int result1 = Multiply(5, 4);
        Console.WriteLine("Multiply(int, int): " + result1);

        double result2 = Multiply(2.5, 3.2);
        Console.WriteLine("Multiply(double, double): " + result2);

        int result3 = Multiply(2, 3, 4);
        Console.WriteLine("Multiply(int, int, int): " + result3);
    }
   */
    
    // Task 10 : 
    
    // Square Area
    static double CalculateArea(double side)
    {
        return side * side;
    }

    // Rectangle Area
    static double CalculateArea(double length, double width)
    {
        return length * width;
    }

    static void Main()
    {
        Console.WriteLine("Choose a shape:");
        Console.WriteLine("1. Square");
        Console.WriteLine("2. Rectangle");

        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter the side: ");
            double side = Convert.ToDouble(Console.ReadLine());

            double area = CalculateArea(side);

            Console.WriteLine("Square Area = " + area);
        }
        else if (choice == 2)
        {
            Console.Write("Enter the length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = CalculateArea(length, width);

            Console.WriteLine("Rectangle Area = " + area);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
    
}
