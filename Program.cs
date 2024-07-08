using System.Security.Cryptography.X509Certificates;

namespace Assignment10._2._2
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public double Salary { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Teachers = new List<Employee>()
               {
                new Employee() { Id = 1, Name = "Mike", Age = 27, Salary = 55000 },
                new Employee() { Id = 2, Name = "Rachell", Age = 35, Salary = 42000 },
                new Employee() { Id = 3, Name = "James", Age = 32, Salary = 36000}
               };

            //Filters employees based on salary and age 
            var filteredEmployees = Teachers.Where(Emp => Emp.Salary > 50000 && Emp.Age < 30);

            //Displays the filtered employees
            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine($"{emp.Name} (Age: {emp.Age}, Salary: ${emp.Salary})");
            }


        }
    }
}
