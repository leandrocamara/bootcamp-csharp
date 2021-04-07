namespace Bootcamp.SOLID.ISP.Correct
{
    public class TaxCalculator
    {
        public double Calculate(ITaxable taxable)
        {
            double total = 0;

            foreach (var item in taxable.ItemsToBeTaxed())
                total += item.Value > 1000 ? item.Value * 0.02 : item.Value * 0.01;

            return total;
        }
    }
}