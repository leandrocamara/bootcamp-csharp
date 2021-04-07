using System;
using System.Collections.Generic;
using System.Text.Json;
using Bootcamp.DesignPatterns.Structural.Facade.CrossCutting;
using Bootcamp.DesignPatterns.Structural.Facade.Domain.Orders;
using Bootcamp.DesignPatterns.Structural.Facade.Domain.Payments;
using Bootcamp.DesignPatterns.Structural.Facade.Domain.Payments.CreditCards;
using Bootcamp.DesignPatterns.Structural.Facade.Domain.Products;
using Bootcamp.DesignPatterns.Structural.Facade.Infrastructure.PayPal;

namespace Bootcamp.DesignPatterns.Structural.Facade
{
    public class FacadeApp
    {
        public static void Execute()
        {
            var order = new Order(new List<Product>
            {
                new("Phone", new Random().Next(2000)),
                new("Laptop", new Random().Next(5000)),
                new("Chair", new Random().Next(500))
            });

            var payment = new Payment(order.Value, PaymentOptions.CreditCard, "5555 2222 5555 9999");

            // Solve with DI
            var paymentCreditCardService = new PaymentCreditCardService(
                new PaymentCreditCardFacade(new PayPalGateway(), new ConfigurationManager()));

            var paymentResult = paymentCreditCardService.MakePayment(order, payment);

            Console.WriteLine(JsonSerializer.Serialize(paymentResult));
        }
    }
}