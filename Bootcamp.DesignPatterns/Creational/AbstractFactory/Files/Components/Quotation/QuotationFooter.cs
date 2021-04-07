namespace Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Components.Quotation
{
    public class QuotationFooter : Footer
    {
        public QuotationFooter(string info) : base(info)
        {
        }

        public override string Serialize()
        {
            return $"##{Info}##";
        }
    }
}