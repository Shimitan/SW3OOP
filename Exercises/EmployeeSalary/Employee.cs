namespace EmployeeSalary
{
    public class Employee
    {
        protected string Name { get; set; }
        protected string JobTitle { get; set; }
        protected double Salary { get; set; }
        protected int Seniority { get; set; }
        
        public Employee(string name, string jobTitle, double salary, int seniority)
        {
            this.Name = name;
            this.JobTitle = jobTitle;
            this.Salary = salary;
            this.Seniority = seniority;
        }

        public virtual double CalculateYearlySalary()
        {
            return (12 * (Salary + (Salary * Seniority*0.1)));
        }
    }
}