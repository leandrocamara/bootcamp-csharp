using Bootcamp.SOLID.OCP.Correct.DeliveryService;
using Bootcamp.SOLID.OCP.Correct.PriceTable;

namespace Bootcamp.SOLID.OCP.Correct
{
    /// <summary>
    /// Open-Closed Principle - Correct Example
    /// </summary>
    public class PriceCalculator
    {
        private readonly IPriceTable _priceTable;
        private readonly IDeliveryService _deliveryService;

        public PriceCalculator(IDeliveryService deliveryService, IPriceTable priceTable)
        {
            _deliveryService = deliveryService;
            _priceTable = priceTable;
        }

        public double Calculate(Purchase purchase)
        {
            var discount = _priceTable.DiscountTo(purchase.Value);

            var shipping = _deliveryService.Calculate(purchase.City);

            return purchase.Value * (1 - discount) + shipping;
        }
    }
}