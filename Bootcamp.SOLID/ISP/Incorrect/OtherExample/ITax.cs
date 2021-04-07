namespace Bootcamp.SOLID.ISP.Incorrect.OtherExample
{
    /// <summary>
    /// Interface Segregation Principle - Incorrect Example
    /// </summary>
    public interface ITax
    {
        Invoice GenerateInvoce();
        double GenerateTax(double value);
    }
}