namespace Bootcamp.SOLID.ISP.Incorrect.OtherExample
{
    public class Iss : ITax
    {
        public Invoice GenerateInvoce() => new Invoice();

        public double GenerateTax(double value) => value * 0.1;
    }
}