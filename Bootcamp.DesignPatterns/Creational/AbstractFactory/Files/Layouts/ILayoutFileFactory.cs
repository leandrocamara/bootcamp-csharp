using Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Components;

namespace Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Layouts
{
    public interface ILayoutFileFactory
    {
        Header CreateHeader(string title);
        Body CreateBody(string content);
        Footer CreateFooter(string info);
    }

    public enum Layout
    {
        Summary = 1,
        Quotation = 2
    }
}