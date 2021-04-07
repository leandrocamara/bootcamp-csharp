namespace Bootcamp.DesignPatterns.Structural.Facade.Domain.Products
{
    public class Product
    {
        public string Name { get; }
        public decimal Value { get; }

        public Product(string name, decimal value)
        {
            Name = name;
            Value = value;
        }
    }
}