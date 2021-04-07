using Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Components;
using Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Components.Quotation;

namespace Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Layouts
{
    public class QuotationLayoutFileFactory : ILayoutFileFactory
    {
        public Header CreateHeader(string title)
        {
            return new QuotationHeader(title);
        }

        public Body CreateBody(string content)
        {
            return new QuotationBody(content);
        }

        public Footer CreateFooter(string info)
        {
            return new QuotationFooter(info);
        }
    }
}