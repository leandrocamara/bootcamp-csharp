namespace Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Components
{
    public abstract class Body
    {
        protected Body(string content)
        {
            Content = content;
        }

        public string Content { get; }

        public abstract string Serialize();
    }
}