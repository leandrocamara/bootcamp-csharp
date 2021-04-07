namespace Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Components.Summary
{
    public class SummaryFooter : Footer
    {
        public SummaryFooter(string info) : base(info)
        {
        }

        public override string Serialize()
        {
            return $"@@{Info}@@";
        }
    }
}