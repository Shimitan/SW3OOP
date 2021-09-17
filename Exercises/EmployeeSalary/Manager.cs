namespace EmployeeSalary
{
    public class Manager : Employee
    {
        private int Bonus { get; set; }

        public Manager(string name, string jobTitle, int salary, int seniority, int bonus) : base(name, jobTitle, salary, seniority)
        {
            this.Bonus = bonus;
        }
        
        public override double CalculateYearlySalary()
        {
            return (12 * (Salary + (Salary * Seniority*0.1) + Bonus));
        }
    }
}