using System;

namespace Bootcamp.SOLID.LSP.Incorrect.Account
{
    public class CommonAccount
    {
        public double Balance { get; protected set; }

        public CommonAccount()
        {
            Balance = 0;
        }

        public void Deposit(double value)
        {
            if (value <= 0) throw new ArgumentOutOfRangeException();

            Balance += value;
        }

        public virtual void Yield()
        {
            Balance *= 1.1;
        }
    }
}