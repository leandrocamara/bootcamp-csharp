namespace Bootcamp.SOLID.OCP.Correct
{
    public class Purchase
    {
        public double Value { get; }
        public string City { get; }

        public Purchase(double value, string city)
        {
            Value = value;
            City = city;
        }
    }
}