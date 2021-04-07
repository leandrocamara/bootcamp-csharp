namespace Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Components
{
    public abstract class Footer
    {
        protected Footer(string info)
        {
            Info = info;
        }

        public string Info { get; }

        public abstract string Serialize();
    }
}