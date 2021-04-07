namespace Bootcamp.SOLID.OCP.Correct.DeliveryService
{
    public class Correios : IDeliveryService
    {
        public double Calculate(string city)
        {
            if (city.ToUpper().Equals("SAO PAULO")) return 15;
            return 30;
        }
    }
}