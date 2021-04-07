namespace Bootcamp.SOLID.DIP.Incorrect
{
    public class Invoice
    {
        public double Value { get; }
        public double Tax { get; }

        public Invoice(double value, double tax)
        {
            Value = value;
            Tax = tax;
        }
    }
}