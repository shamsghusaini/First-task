namespace _15_Tasks;

class Program
{
    static void Main(string[] args)
    {

        
        // Task 1
        Console.WriteLine("Please Enter Your Name:");
        String userName =   Console.ReadLine();

        Console.WriteLine("Please Enter Your Age:");
        int userAge = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your Height(meters):");
        double userHeight = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your Student status:");
        bool userstatus = bool.Parse(Console.ReadLine());

        Console.WriteLine(" Name: " + userName + ", Age: "  + userAge + ", Height: " + userHeight
        + ", Student status: " + userstatus);

        // Task 2
        Console.WriteLine("Enter the length of rectangle: ");
        float length = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter width of rectangle: ");
        float width = float.Parse(Console.ReadLine());

        float Area = length * width;
        Console.WriteLine("The area of the rectangle is : " + Area);

        float perimeter = (length + width) * 2;
        Console.WriteLine("The perimeter of the rectangle is : " + perimeter);

        //Task 3
        Console.WriteLine("Enter a whole number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is Even");
        }
        else
        {
            Console.WriteLine("The number is Odd");
        }

        //Task 4
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Do you have a valid ID? (YES/NO): ");
        string answer = Console.ReadLine().ToLower();

        bool hasID = answer == "yes";
        if (age >= 18 && hasID)
        {
            Console.WriteLine("Eligible to vote");
        }
        else
        {
            Console.WriteLine("Not Eligible to vote");
        }
        //Task 5
        Console.WriteLine("Enter your Grade ('A''B','C','D' or 'F'): ");
        char grade = char.Parse(Console.ReadLine());

        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent");
                break;
            case 'B':
                Console.WriteLine("Very Good");
                break;
            case 'C':
                Console.WriteLine("Good");
                break;
            case 'D':
                Console.WriteLine("Pass");
                break;
            case 'F':
                Console.WriteLine("Fail");
                break;

            default:
                Console.WriteLine("Invalid Grade");
                break;
        }

        //Task 6
    {
        Console.WriteLine("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine("The temperature in Fahrenheit is : " + fahrenheit);

        if (celsius < 10)
        {
            Console.WriteLine("Weather: Cold");
        }
        else if (celsius <= 30)
        {
            Console.WriteLine("Weather: Mild");
        }
        else
        {
            Console.WriteLine("Weather: Hot");
        }
    }

    //Task 7
    Console.WriteLine("Enter your Age: ");
    int age = int.Parse(Console.ReadLine());

    if (age >= 0 && age <= 12)
    {
        Console.WriteLine("Category: Child");
        Console.WriteLine("Ticket Price: 2.00 OMR");
    }
    else if (age >= 13 && age <= 59)
        {
        Console.WriteLine("Category: Adult");
        Console.WriteLine("Ticket Price: 5.00 OMR");
        }
    else
    {
        Console.WriteLine("Category: Senior");
        Console.WriteLine("Ticket Price: 3.00 OMR");
    }

        // Task 8
        Console.WriteLine("Enter total bill amount : ");
        double bill = double.Parse(Console.ReadLine());

        Console.WriteLine("Are you a loyalty member? Yes/No: ");
        string loyaltyMember = Console.ReadLine();

        bool isMember = loyaltyMember == "Yes";
        double discount = 0;
        if (bill > 20 && isMember)
        {
            discount = bill * 0.15;
        }
        double total = bill - discount;

        Console.WriteLine("Original Bill: " + bill + " OMR");
        Console.WriteLine("Discount: " + discount + " OMR");
        Console.WriteLine("Total Bill: " + total + " OMR");

        // Task 9
        Console.WriteLine("Enter a number of the day: ");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }


        //Task 10
        Console.WriteLine("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter operator( +, -, *, /, %) : ");
        char operatorSign = char.Parse(Console.ReadLine());

        switch (operatorSign)
        {
            case '+':
                Console.WriteLine("Result: " + (firstNumber + secondNumber));
                break;
            case '-':
                Console.WriteLine("Result: " + (firstNumber - secondNumber));
                break;
            case '*':
                Console.WriteLine("Result: " + (firstNumber * secondNumber));
                break;
            case '/':
                Console.WriteLine("Result: " + (firstNumber / secondNumber));
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
                
         }
        
            //Task 11
            Console.WriteLine("Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Your Monthly Income: ");
            int income =int.Parse(Console.ReadLine());
            
            Console.WriteLine("Do you have an existing loan? (yes/no) ");
            string loan = Console.ReadLine();
            if (age >= 21 && age <= 60)
            {
                if (income >= 400)
                {
                    if (loan == "no")
                    {
                        Console.WriteLine("Eligible for loan");
                    }
                    else
                    {
                        Console.WriteLine("Not eligible, because you have loan");
                    }
                }
                else
                {
                    Console.WriteLine("Income too low");
                }
            }
            else
            {
                Console.WriteLine("Age not accepted");
            }
             
        // Task 12 
                Console.WriteLine("Enter a region code (A, B, C):");
                char region = char.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Package weight");
                double weight = double.Parse(Console.ReadLine());

                double basecost = 0;
                double extracharge = 0;
                switch (region)
                {
                    case 'A':
                        basecost = 1;
                        break;
                    case 'B':
                        basecost = 2;
                        break;
                    case 'C':
                        basecost = 3;
                        break;

                        default:
                            Console.WriteLine("Invalid region");
                            return;
                }
                if (weight > 10)
                    {
                    extracharge = 5;
                    }
                else if (weight > 5);
                {
                    extracharge = 2;
                }
                
                double total = basecost + extracharge;
                Console.WriteLine(" Base Cost: " + basecost + " OMR");
                Console.WriteLine(" Extra Charge: " + extracharge + " OMR");
                Console.WriteLine(" Total Shipping Cost: " + total + " OMR");


    }
}