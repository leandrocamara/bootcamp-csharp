using Bootcamp.DesignPatterns.Creational.AbstractFactory;
using Bootcamp.DesignPatterns.Creational.FactoryMethod;
using Bootcamp.DesignPatterns.Creational.Singleton;
using Bootcamp.DesignPatterns.Structural.Adapter;
using Bootcamp.DesignPatterns.Structural.Facade;

namespace Bootcamp.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creational
            AbstractFactoryApp.Execute();
            FactoryMethodApp.Execute();
            SingletonApp.Execute();

            // Structural
            AdapterApp.Execute();
            FacadeApp.Execute();
        }
    }
}