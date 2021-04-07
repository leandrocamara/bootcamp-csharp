namespace Bootcamp.SOLID.OCP.Incorrect
{
    /// <summary>
    /// Open-Closed Principle - Incorrect Example
    /// </summary>
    public class PriceCalculator
    {
        public double Calculate(Purchase purchase)
        {
            double discount = 0;
            var correios = new Correios();

            if (purchase.Value > 100) // Rule 1
            {
                var standardPriceTabletable = new StandardPriceTable();
                discount = standardPriceTabletable.DiscountTo(purchase.Value);
            }

            if (purchase.Value > 200) // Rule 2
            {
                var differentiatedPriceTable = new DifferentiatedPriceTable();
                discount = differentiatedPriceTable.DiscountTo(purchase.Value);
            }
            
            // Rule 3
            // Rule ...

            var shipping = correios.Calculate(purchase.City);

            return purchase.Value * (1 - discount) + shipping;
        }
    }
}