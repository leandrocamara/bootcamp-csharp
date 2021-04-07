using System;

namespace Bootcamp.DesignPatterns.Creational.Singleton
{
    public class Database
    {
        private static readonly Database Instance = new Database();

        public string Connection { get; }
        
        private Database()
        {
            Connection = Guid.NewGuid().ToString();
        }

        public static Database GetInstance()
        {
            return Instance;
        }

        public void Execute(string query)
        {
            Console.WriteLine($"Database Connection: {Connection}");
            Console.WriteLine("Executing...");
            Console.WriteLine(query);
            Console.WriteLine();
        }
    }
}