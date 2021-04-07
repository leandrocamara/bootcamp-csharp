using Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Components;
using Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Components.Summary;

namespace Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Layouts
{
    public class SummaryLayoutFileFactory : ILayoutFileFactory
    {
        public Header CreateHeader(string title)
        {
            return new SummaryHeader(title);
        }

        public Body CreateBody(string content)
        {
            return new SummaryBody(content);
        }

        public Footer CreateFooter(string info)
        {
            return new SummaryFooter(info);
        }
    }
}