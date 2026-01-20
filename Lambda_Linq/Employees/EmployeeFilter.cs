namespace Lambda_Linq;

public class EmployeeFilter
{
    public static void Run()
    {
        Console.WriteLine(" Employees Joined in Last 6 Months (IT Dept)");

        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Amit", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-3) },
                new Employee { Name = "Ravi", Department = "HR", JoiningDate = DateTime.Now.AddMonths(-2) },
                new Employee { Name = "Neha", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-7) },
                new Employee { Name = "Suman", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-1) }
        };

        var filterEmployees = employees.Where(e => e.Department == "IT" &&
        e.JoiningDate >= DateTime.Now.AddMonths(-6));

        foreach (var emp in filterEmployees)
        {
            Console.Write($"{emp.Name} - {emp.Department} - {emp.JoiningDate.ToShortDateString()}");
            Console.WriteLine();
        }

        Console.WriteLine();

    }
}
