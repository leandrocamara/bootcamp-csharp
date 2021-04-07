using System;
using Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Layouts;

namespace Bootcamp.DesignPatterns.Creational.AbstractFactory.Files
{
    public class FileSerializer
    {
        private readonly File _file;
        private readonly ILayoutFileFactory _factory;

        private FileSerializer(ILayoutFileFactory factory, File file)
        {
            _file = file;
            _factory = factory;
        }

        public static FileSerializer Create(File file)
        {
            return file.Layout switch
            {
                Layout.Summary => new FileSerializer(new SummaryLayoutFileFactory(), file),
                Layout.Quotation => new FileSerializer(new QuotationLayoutFileFactory(), file),
                _ => throw new ArgumentException($"Invalid File Layout: {file.Layout}")
            };
        }

        public void Serialize()
        {
            Console.WriteLine(_file.Layout);
            Console.WriteLine($"{_factory.CreateHeader(_file.Title).Serialize()}\n" +
                              $"{_factory.CreateBody(_file.Content).Serialize()}\n" +
                              $"{_factory.CreateFooter(_file.Info).Serialize()}\n");
        }
    }
}