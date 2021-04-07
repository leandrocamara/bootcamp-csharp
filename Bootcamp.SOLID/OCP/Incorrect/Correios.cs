namespace Bootcamp.SOLID.OCP.Incorrect
{
    public class Correios
    {
        public double Calculate(string city)
        {
            if (city.ToUpper().Equals("SAO PAULO")) return 15;
            return 30;
        }
    }
}