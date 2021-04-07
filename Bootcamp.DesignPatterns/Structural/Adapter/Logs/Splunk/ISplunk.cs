using System;

namespace Bootcamp.DesignPatterns.Structural.Adapter.Logs.Splunk
{
    public interface ISplunk
    {
        public void Log(string message);
        public void LogException(Exception exception);   
    }
}