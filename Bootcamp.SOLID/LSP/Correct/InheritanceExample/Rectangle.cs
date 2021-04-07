namespace Bootcamp.SOLID.LSP.Correct.InheritanceExample
{
    public class Rectangle
    {
        public double B { get; }
        public double H { get; }

        public Rectangle(double b, double h)
        {
            B = b;
            H = h;
        }

        public double CalculateArea()
        {
            return B * H;
        }
    }
}