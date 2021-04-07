namespace Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Components.Summary
{
    public class SummaryBody : Body
    {
        public SummaryBody(string content) : base(content)
        {
        }

        public override string Serialize()
        {
            return $"@@{Content}@@";
        }
    }
}