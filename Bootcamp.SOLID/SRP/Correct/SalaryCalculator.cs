namespace Bootcamp.SOLID.SRP.Correct
{
    /// <summary>
    /// Single Responsibility Principle - Correct Example
    /// </summary>
    public class SalaryCalculator
    {
        public double Calculate(Employee employee)
        {
            return employee.Office.Rule().Calculate(employee.Salary);
        }
    }
}