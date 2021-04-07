using System.Collections.Generic;

namespace Bootcamp.SOLID.ISP.Correct
{
    public interface ITaxable
    {
        IReadOnlyList<Item> ItemsToBeTaxed();
    }
}