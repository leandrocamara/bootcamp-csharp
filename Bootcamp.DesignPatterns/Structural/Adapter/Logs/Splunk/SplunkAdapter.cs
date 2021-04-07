using System;

namespace Bootcamp.DesignPatterns.Structural.Adapter.Logs.Splunk
{
    public class SplunkAdapter : ILogger
    {
        private readonly ISplunk _splunk;

        public SplunkAdapter(ISplunk splunk)
        {
            _splunk = splunk;
        }

        public void Log(string message)
        {
            _splunk.Log(message);
        }

        public void LogException(Exception exception)
        {
            _splunk.LogException(exception);
        }
    }
}