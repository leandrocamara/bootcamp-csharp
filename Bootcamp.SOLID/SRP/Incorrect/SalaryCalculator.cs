using System;

namespace Bootcamp.SOLID.SRP.Incorrect
{
    /// <summary>
    /// Single Responsibility Principle - Incorrect Example
    /// </summary>
    public class SalaryCalculator
    {
        public double Calculate(Employee employee)
        {
            if (employee.Office.Equals(Office.Developer))
                return ReduceTenPercent(employee);

            if (employee.Office.Equals(Office.Manager))
                return ReduceTwentyFivePercent(employee);

            throw new ArgumentException("Invalid Employee!");
        }

        private double ReduceTenPercent(Employee employee)
        {
            return employee.Salary * 0.9;
        }

        private double ReduceTwentyFivePercent(Employee employee)
        {
            return employee.Salary * 0.75;
        }
    }
}