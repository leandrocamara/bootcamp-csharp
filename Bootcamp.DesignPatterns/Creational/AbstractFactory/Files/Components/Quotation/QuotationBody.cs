namespace Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Components.Quotation
{
    public class QuotationBody : Body
    {
        public QuotationBody(string content) : base(content)
        {
        }

        public override string Serialize()
        {
            return $"##{Content}##";
        }
    }
}