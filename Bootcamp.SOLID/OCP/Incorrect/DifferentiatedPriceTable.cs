namespace Bootcamp.SOLID.OCP.Incorrect
{
    public class DifferentiatedPriceTable
    {
        public double DiscountTo(double value)
        {
            if (value > 3000) return 0.05;
            if (value > 500) return 0.07;
            return 0;
        }
    }
}