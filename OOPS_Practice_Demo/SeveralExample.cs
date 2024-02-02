using OOPS_Practice_Demo;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

class SeveralExample
{
    public static void Main_SeveralExample(String[] args)
    {
        List<DateTime> datetimes = new List<DateTime>
        {
            new DateTime(2024, 1, 10),
            new DateTime(2024, 1, 22),
            new DateTime(2024, 1, 15),
            new DateTime(2024, 1, 13),
            new DateTime(2024, 1, 18),
        };

        DateTime today = DateTime.Today;
        DateTime LastWeek = today.AddDays(-7);
        var result = datetimes.Where(d => d>= LastWeek && d <= today).OrderBy(d => d);
        foreach (var item in result)
        {
            Console.WriteLine("Past Week dates => {0}", Convert.ToString(item));
        }

        List<string> names = new List<string>
        {
            "Chintan",
            "Jekin",
            "Chirag",
            "Chokers",
            "JapaCN"
        };
        var namesStartWith = names.Where(n => n.StartsWith("C")).ToList();
        foreach (var item in namesStartWith)
        {
            Console.WriteLine("Name Start with 'C' => {0}", item);
        }

        List < Employee > employees = DataManager.GetData();
        List<Department> departments = DataManager.GetDepartment();

        //IEnumerable<string> names = employees.Select(e => e.FirstName).Distinct();

        // Query syntax
        var emps1 = (from employee in employees
                     orderby employee.FirstName, employee.Age
                     select employee).ToList();
        //emps1.ForEach(e => { Console.WriteLine(e.FirstName + " " + e.LastName + " " + e.Age); });

        // Method syntax
        var emps2 = employees.OrderBy(e => e.FirstName).ThenBy(e => e.Age);


        //var innerJoin = employees.Join(
        //    departments,
        //    e => e.DepartmentId,
        //    d => d.ID
        //    (employee, department) => new
        //    {
        //        employee.FirstName,
        //        d.DepartmentName
        //    });

        // LINQ Join
        var innerJoin = from emp in employees
                        join dep in departments
                        on emp.DepartmentId equals dep.ID
                        select new
                        {
                            emp.FirstName,
                            emp.LastName,
                            dep.DepartmentName
                        };

        foreach (var item in innerJoin)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.DepartmentName);
        }

        var TotalEmployee = (from emp in employees
                             select emp).Count();
        Console.WriteLine("Total Employee => {0}", TotalEmployee);

        var nameList = employees.Where(e => e.FirstName.StartsWith("J")).ToList();
        foreach (var item in nameList)
        {
            Console.WriteLine(item.FirstName);
        }

        Console.WriteLine(employees.Any(e => e.Age > 30));
        Console.WriteLine(employees.All(e => e.Age > 30));
        Console.WriteLine(employees.Count(e => e.Age > 30));
        Console.WriteLine(employees.Max(e => e.Salary));
        var empMinBy = employees.MinBy(e => e.Salary);
        Console.WriteLine("Employee min by => {0}", empMinBy?.FirstName);
        Console.WriteLine(employees.Where(e => e.Salary < 30000).Sum(e => e.Salary));

        List<int> numbersInt = new List<int> { 1, 92, 23, 44, 5 };
        var numEven = numbersInt.Where(n => n % 2 == 0).ToList();

        var numberDesc = employees.OrderByDescending(e => e.ID);
        foreach (var item in numberDesc)
        {
            Console.WriteLine(item.ID + " " + item.FirstName);
        }

        //I2DShape circle = new Circle(5);
        //I2DShape rect = new Rectangle { Length = 5, Breadth = 4 };
        //I3DShape cube = new Cube { Side = 5 };
        //Console.WriteLine(circle.Getarea());
        //Console.WriteLine(rect.Getarea());
        //Console.WriteLine(cube.GetVolume());
    }
}