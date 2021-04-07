namespace Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Components
{
    public abstract class Header
    {
        protected Header(string title)
        {
            Title = title;
        }

        public string Title { get; }

        public abstract string Serialize();
    }
}