using System;

namespace Bootcamp.DesignPatterns.Structural.Adapter.Logs
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Standard Logger: {message}");
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine($"Standard Logger: Exception {exception.Message}");
        }
    }
}