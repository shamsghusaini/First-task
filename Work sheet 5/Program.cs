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
       
       
       
    }
}