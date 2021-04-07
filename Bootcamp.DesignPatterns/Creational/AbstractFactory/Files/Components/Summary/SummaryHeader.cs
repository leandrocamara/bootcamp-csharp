namespace Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Components.Summary
{
    public class SummaryHeader : Header
    {
        public SummaryHeader(string title) : base(title)
        {
        }

        public override string Serialize()
        {
            return $"@@{Title}@@";
        }
    }
}