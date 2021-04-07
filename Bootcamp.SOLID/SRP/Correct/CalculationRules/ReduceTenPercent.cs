namespace Bootcamp.SOLID.SRP.Correct.CalculationRules
{
    public class ReduceTenPercent : ICalculationRule
    {
        public double Calculate(double value) => value * 0.9;
    }
}