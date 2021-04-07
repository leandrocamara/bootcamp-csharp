namespace Bootcamp.SOLID.SRP.Correct.CalculationRules
{
    public class ReduceTwentyFivePercent : ICalculationRule
    {
        public double Calculate(double value) => value * 0.75;
    }
}