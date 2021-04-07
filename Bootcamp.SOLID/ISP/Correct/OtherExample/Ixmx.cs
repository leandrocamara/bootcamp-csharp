namespace Bootcamp.SOLID.ISP.Correct.OtherExample
{
    public class Ixmx : ITaxCalculator
    {
        public double GenerateTax(double value) => value * 0.2;
    }
}