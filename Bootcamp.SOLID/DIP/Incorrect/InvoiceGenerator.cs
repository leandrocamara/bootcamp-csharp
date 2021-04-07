namespace Bootcamp.SOLID.DIP.Incorrect
{
    /// <summary>
    /// Dependecy Inversion Principle - Incorrect Example
    /// </summary>
    public class InvoiceGenerator
    {
        private readonly InvoiceDao _invoiceDao;
        private readonly EmailSender _emailSender;

        public InvoiceGenerator(InvoiceDao invoiceDao, EmailSender emailSender)
        {
            _invoiceDao = invoiceDao;
            _emailSender = emailSender;
        }

        public Invoice Generate(double value)
        {
            var invoice = new Invoice(value, GetSimplexTax(value));

            _emailSender.Send(invoice);
            _invoiceDao.Save(invoice);

            return invoice;
        }

        private double GetSimplexTax(double value) => value * 0.06;
    }
}