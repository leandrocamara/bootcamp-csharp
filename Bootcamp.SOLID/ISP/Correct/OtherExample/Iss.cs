namespace Bootcamp.SOLID.ISP.Correct.OtherExample
{
    public class Iss : ITaxCalculator, IInvoiceGenerator
    {
        public double GenerateTax(double value) => value * 0.1;

        public Invoice GenerateInvoce() => new Invoice();
    }
}