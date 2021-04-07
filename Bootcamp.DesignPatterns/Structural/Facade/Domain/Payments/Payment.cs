namespace Bootcamp.DesignPatterns.Structural.Facade.Domain.Payments
{
    public class Payment
    {
        public string Status { get; private set; }
        public decimal Value { get; }
        public PaymentOptions PaymentOption { get; }
        public string CreditCard { get; }

        public Payment(decimal value, PaymentOptions paymentOption, string creditCard)
        {
            Value = value;
            PaymentOption = paymentOption;
            CreditCard = creditCard;
        }

        public void SuccessfulPayment()
        {
            Status = "Successful";
        }

        public void FailedPayment()
        {
            Status = "Failed";
        }
    }
}