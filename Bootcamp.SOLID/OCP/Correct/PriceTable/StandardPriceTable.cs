namespace Bootcamp.SOLID.OCP.Correct.PriceTable
{
    public class StandardPriceTable : IPriceTable
    {
        public double DiscountTo(double value)
        {
            if (value > 5000) return 0.03;
            if (value > 1000) return 0.05;
            return 0;
        }
    }
}