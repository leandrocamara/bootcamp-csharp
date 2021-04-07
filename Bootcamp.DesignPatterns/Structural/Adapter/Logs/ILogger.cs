using System;

namespace Bootcamp.DesignPatterns.Structural.Adapter.Logs
{
    public interface ILogger
    {
        public void Log(string message);
        public void LogException(Exception exception);
    }
}