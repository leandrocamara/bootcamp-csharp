using System;
using System.Collections.Generic;
using Bootcamp.SOLID.LSP.Incorrect.Account;

namespace Bootcamp.SOLID.LSP.Incorrect
{
    /// <summary>
    /// Liskov Substitutive Principle - Incorrect Example
    /// </summary>
    public class InvestmentProcessor
    {
        public void Process(IEnumerable<CommonAccount> accounts)
        {
            foreach (var account in accounts)
            {
                account.Yield();
                Console.WriteLine($"New Balance: {account.Balance}");
            }
        }
    }
}