using System.Collections.Generic;

namespace Bootcamp.SOLID.ISP.Incorrect
{
    public class Invoice
    {
        public double Value { get; }
        public IList<Item> Items { get; }

        public Invoice(double value, IList<Item> items)
        {
            Value = value;
            Items = items;
        }
    }
}