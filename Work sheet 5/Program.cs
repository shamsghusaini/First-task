namespace Work_sheet_5;

class Program
{
    static void Main(string[] args)
    {
        /*
       // Task 1 :
       int[] grades = new int[5];

       // Input grades
       for (int i = 0; i < grades.Length; i++)
       {
           Console.Write($"Enter grade {i + 1}: ");
           grades[i] = Convert.ToInt32(Console.ReadLine());
       }

       // Print grades
       Console.WriteLine("\nStudent Grades:");
       foreach (int grade in grades)
       {
           Console.WriteLine(grade);
       }
       
       
       // Task 2: 
       List<string> tasks = new List<string>();
       
       for (int i = 0; i < 5; i++)
       {
           Console.WriteLine($"Enter Task{i + 1}: ");
           string task = Console.ReadLine();
           tasks.Add(task);
       }
       
       Console.WriteLine();
       Console.WriteLine("To do List");
           foreach (string task in tasks)
               {
               Console.WriteLine( "- " + task);
               }
        
           
           
        // Task 3: 
        Stack<string> history = new Stack<string>();

        
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter website {i + 1}: ");
            string website = Console.ReadLine();
            history.Push(website);
        }

        // Go back once
        string removedPage = history.Pop();

        Console.WriteLine();
        Console.WriteLine("You went back from: " + removedPage);
        Console.WriteLine("Current page: " + history.Peek());
        
        
        
        
        // Task 4:
        Queue<string> customers = new Queue<string>();

        // Enter 3 customer names
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter customer {i + 1}: ");
            string name = Console.ReadLine();
            customers.Enqueue(name);
        }

        // Serve the first customer
        string servedCustomer = customers.Dequeue();

        Console.WriteLine();
        Console.WriteLine("Served customer: " + servedCustomer);
        Console.WriteLine("Next customer: " + customers.Peek());
        
        
        
        // Task 5:
        int[] grades = new int[5];
        int sum = 0;

        // Input grades
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write($"Enter grade {i + 1}: ");
            grades[i] = Convert.ToInt32(Console.ReadLine());
            sum += grades[i];
        }

        // Sort the array
        Array.Sort(grades);

        int lowest = grades[0];
        int highest = grades[grades.Length - 1];
        double average = (double)sum / grades.Length;

        Console.WriteLine();
        Console.WriteLine("Lowest grade: " + lowest);
        Console.WriteLine("Highest grade: " + highest);
        Console.WriteLine("Average grade: " + average);
        
        */
        
        // Task 6: 
        List<string> shoppingList = new List<string>();

        string item = "";

        // Add items
        while (item != "done")
        {
            Console.Write("Enter an item (or type 'done' to finish): ");
            item = Console.ReadLine();

            if (item != "done")
            {
                shoppingList.Add(item);
            }
        }

        // Print before removal
        Console.WriteLine("\nShopping List:");
        foreach (string product in shoppingList)
        {
            Console.WriteLine("- " + product);
        }

        // Remove an item
        Console.Write("\nEnter an item to remove: ");
        string removeItem = Console.ReadLine();

        shoppingList.Remove(removeItem);

        // Print after removal
        Console.WriteLine("\nUpdated Shopping List:");
        foreach (string product in shoppingList)
        {
            Console.WriteLine("- " + product);
        }
        
        
    }
}