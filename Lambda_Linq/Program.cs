namespace Lambda_Linq;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //EmployeeFilter.Run();

        // Pronlem 2
        //StringSorter.Run();

        // Problem 3
        //ProductGrouping.Run();

        // Problem 7
        List<Student> students = new List<Student>
        {
            new Student(101, "Alice", 85),
            new Student(102, "Bob", 92),
            new Student(103, "Charlie", 85),
            new Student(104, "David", 75)
        };

        
        students.Sort(new StudentComparer());

        
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        Console.ReadKey();
    }
}
