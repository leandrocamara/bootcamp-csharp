using System.Collections.Generic;
using Bootcamp.DesignPatterns.Creational.AbstractFactory.Files;
using Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Layouts;

namespace Bootcamp.DesignPatterns.Creational.AbstractFactory
{
    public class AbstractFactoryApp
    {
        public static void Execute()
        {
            var files = new List<File>
            {
                new(Layout.Quotation, "QuotationTitle", "QuotationContent", "QuotationInfo"),
                new(Layout.Summary, "SummaryTitle", "SummaryContent", "SummaryInfo")
            };
            
            files.ForEach(file => FileSerializer.Create(file).Serialize());
        }
    }
}