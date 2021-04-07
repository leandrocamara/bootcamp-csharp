using System.Collections.Generic;
using System.Collections.Immutable;

namespace Bootcamp.SOLID.ISP.Correct
{
    public class Invoice : ITaxable
    {
        public double Value { get; }
        public IList<Item> Items { get; }

        public Invoice(double value, IList<Item> items)
        {
            Value = value;
            Items = items;
        }

        public IReadOnlyList<Item> ItemsToBeTaxed()
        {
            return Items.ToImmutableList();
        }
    }
}