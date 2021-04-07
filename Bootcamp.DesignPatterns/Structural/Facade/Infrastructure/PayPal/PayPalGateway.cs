using System;
using System.Linq;

namespace Bootcamp.DesignPatterns.Structural.Facade.Infrastructure.PayPal
{
    public interface IPayPalGateway
    {
        string GetPayPalServiceKey(string apiKey, string encriptionKey);
        string GetCardHashKey(string serviceKey, string cartaoCredito);
        bool CommitTransaction(string cardHashKey, string orderId, decimal amount);
    }

    public class PayPalGateway : IPayPalGateway
    {
        public bool CommitTransaction(string cardHashKey, string orderId, decimal amount)
        {
            return new Random().Next(2) == 0;
        }

        public string GetCardHashKey(string serviceKey, string cartaoCredito)
        {
            return new(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }

        public string GetPayPalServiceKey(string apiKey, string encriptionKey)
        {
            return new(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}