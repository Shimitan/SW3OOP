using System;

namespace EmployeeSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Mike", "Coomer", 500, 1);
            Manager manager1 = new Manager("Sigurd", "Manager of BoobaTV", 50000, 7, 10000);

            Console.WriteLine(employee1.CalculateYearlySalary());
            Console.WriteLine(manager1.CalculateYearlySalary());
            

        }
    }
}