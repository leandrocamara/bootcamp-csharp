using Bootcamp.DesignPatterns.Structural.Facade.CrossCutting;
using Bootcamp.DesignPatterns.Structural.Facade.Domain.Orders;
using Bootcamp.DesignPatterns.Structural.Facade.Infrastructure.PayPal;

namespace Bootcamp.DesignPatterns.Structural.Facade.Domain.Payments.CreditCards
{
    public interface IPaymentCreditCardFacade
    {
        bool MakePayment(Order order, Payment payment);
    }

    public class PaymentCreditCardFacade : IPaymentCreditCardFacade
    {
        private readonly IPayPalGateway _payPalGateway;
        private readonly IConfigurationManager _configurationManager;

        public PaymentCreditCardFacade(IPayPalGateway payPalGateway, IConfigurationManager configurationManager)
        {
            _payPalGateway = payPalGateway;
            _configurationManager = configurationManager;
        }

        public bool MakePayment(Order order, Payment payment)
        {
            var apiKey = _configurationManager.GetValue("apiKey");
            var encriptionKey = _configurationManager.GetValue("encriptionKey");

            var serviceKey = _payPalGateway.GetPayPalServiceKey(apiKey, encriptionKey);
            var cardHashKey = _payPalGateway.GetCardHashKey(serviceKey, payment.CreditCard);

            return _payPalGateway.CommitTransaction(cardHashKey, order.Id.ToString(), payment.Value);
        }
    }
}