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
        
        // Task 2 :
        Console.WriteLine("Enter a positive number:");
        int positiveNumber = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= positiveNumber; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine("sum = " + sum);
        
        //Task 3:
        Console.WriteLine("Enter a Number");
        int Number = int.Parse(Console.ReadLine());
        
        for (int i = 1 ; i <= 10 ; i++)
        {
            Console.WriteLine(Number + " x " + i + " = " + (Number * i));
        }
        
        // Task 4: 
        string correctpassword = "Spark2026";
        string password = " ";

        while (password != correctpassword)
        {
            Console.WriteLine("Enter a password: ");
            password = Console.ReadLine();


            if (password != correctpassword)
            {
                Console.WriteLine("Incorrect password, try again");
            }
        }

        Console.WriteLine("Access Granted");
        
        //Task 5: 
        int secreteNumber = 42;
        int guess;
        int attempts = 0;

        do
        {
          Console.WriteLine("Guess the number: ");
          guess = int.Parse(Console.ReadLine());
          attempts++;

          if (guess > secreteNumber)
          {
              Console.WriteLine("Too high");
          }
          else if (guess < secreteNumber)
              {
              Console.WriteLine("Too low");
              }
          else
              Console.WriteLine("Correct");
        } 
        while (guess != secreteNumber);
        Console.WriteLine("Attempets: " + attempts);

        // Task 6:
        try
        {
            Console.WriteLine("Enter First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 / num2;

            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (Exception)
        {
            Console.WriteLine("Incorrect input! please enter number only!");
        }




    }
}