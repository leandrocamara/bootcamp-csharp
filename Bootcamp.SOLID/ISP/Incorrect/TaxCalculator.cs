namespace Bootcamp.SOLID.ISP.Incorrect
{
    public class TaxCalculator
    {
        public double Calculate(Invoice invoice)
        {
            double total = 0;

            foreach (var item in invoice.Items)
                total += item.Value > 1000 ? item.Value * 0.02 : item.Value * 0.01;
            
            return total;
        }
    }
}