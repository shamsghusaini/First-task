namespace Work_sheet_5;

class Program
{
    static void Main(string[] args)
    {
        
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
    }
}