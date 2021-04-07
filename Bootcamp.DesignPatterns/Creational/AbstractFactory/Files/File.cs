using Bootcamp.DesignPatterns.Creational.AbstractFactory.Files.Layouts;

namespace Bootcamp.DesignPatterns.Creational.AbstractFactory.Files
{
    public class File
    {
        public Layout Layout { get; }
        public string Title { get; }
        public string Content { get; }
        public string Info { get; }

        public File(Layout layout, string title, string content, string info)
        {
            Layout = layout;
            Title = title;
            Content = content;
            Info = info;
        }
    }
}