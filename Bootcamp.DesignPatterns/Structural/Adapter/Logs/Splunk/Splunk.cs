using System;

namespace Bootcamp.DesignPatterns.Structural.Adapter.Logs.Splunk
{
    public class Splunk : ISplunk
    {
        public void Log(string message)
        {
            Console.WriteLine($"Splunk Logger: {message}");
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine($"Splunk Logger: Exception {exception.Message}");
        }
    }
}