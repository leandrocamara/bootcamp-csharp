namespace Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Components.Quotation
{
    public class QuotationHeader : Header
    {
        public QuotationHeader(string title) : base(title)
        {
        }

        public override string Serialize()
        {
            return $"##{Title}##";
        }
    }
}