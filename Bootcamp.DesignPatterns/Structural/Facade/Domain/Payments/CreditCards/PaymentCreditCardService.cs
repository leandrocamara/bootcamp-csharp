using Bootcamp.DesignPatterns.Structural.Facade.Domain.Orders;

namespace Bootcamp.DesignPatterns.Structural.Facade.Domain.Payments.CreditCards
{
    public interface IPaymentCreditCardService
    {
        Payment MakePayment(Order order, Payment payment);
    }

    public class PaymentCreditCardService : IPaymentCreditCardService
    {
        private readonly IPaymentCreditCardFacade _paymentCreditCardFacade;

        public PaymentCreditCardService(IPaymentCreditCardFacade paymentCreditCardFacade)
        {
            _paymentCreditCardFacade = paymentCreditCardFacade;
        }

        public Payment MakePayment(Order order, Payment payment)
        {
            if (_paymentCreditCardFacade.MakePayment(order, payment))
                payment.SuccessfulPayment();
            else
                payment.FailedPayment();

            return payment;
        }
    }
}