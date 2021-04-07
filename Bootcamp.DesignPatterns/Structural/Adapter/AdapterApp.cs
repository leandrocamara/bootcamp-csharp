using Bootcamp.DesignPatterns.Structural.Adapter.Logs;
using Bootcamp.DesignPatterns.Structural.Adapter.Logs.Splunk;

namespace Bootcamp.DesignPatterns.Structural.Adapter
{
    public class AdapterApp
    {
        public static void Execute()
        {
            var logger = new Logger();
            new TemperatureSensorService(logger).Monitor();

            var splunk = new SplunkAdapter(new Splunk());
            new TemperatureSensorService(splunk).Monitor();
        }
    }
}