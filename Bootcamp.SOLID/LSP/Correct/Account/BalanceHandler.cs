using System;

namespace Bootcamp.SOLID.LSP.Correct.Account
{
    /// <summary>
    /// Liskov Substitutive Principle - Correct Example
    /// </summary>
    public class BalanceHandler
    {
        public double Balance { get; private set; }

        public void Add(double value)
        {
            if (value <= 0) throw new ArgumentOutOfRangeException();
            Balance += value;
        }

        public void Remove(double value)
        {
            if (value <= 0) throw new ArgumentOutOfRangeException();
            Balance -= value;
        }

        public void Yield(double tax)
        {
            Balance *= 1 + tax;
        }
    }
}