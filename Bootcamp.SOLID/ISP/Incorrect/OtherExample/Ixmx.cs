using System;

namespace Bootcamp.SOLID.ISP.Incorrect.OtherExample
{
    public class Ixmx : ITax
    {
        public Invoice GenerateInvoce() => throw new NotSupportedException();

        public double GenerateTax(double value) => value * 0.2;
    }
}