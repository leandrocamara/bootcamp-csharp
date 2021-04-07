using System;
using System.Threading;
using Bootcamp.DesignPatterns.Structural.Adapter.Logs;

namespace Bootcamp.DesignPatterns.Structural.Adapter
{
    public class TemperatureSensorService
    {
        private readonly ILogger _logger;
        private readonly Random _random;

        public TemperatureSensorService(ILogger logger)
        {
            _logger = logger;
            _random = new Random();
        }

        public void Monitor()
        {
            _logger.Log("Monitoring started...");

            var consecutiveAlerts = 0;

            while (consecutiveAlerts < 5)
            {
                try
                {
                    var temperature = GetTemperature();

                    if (IsUnacceptableTemperature(temperature))
                        throw new Exception($"Unacceptable temperature: {temperature}");

                    _logger.Log($"Temperature: {temperature}");
                }
                catch (Exception e)
                {
                    consecutiveAlerts++;
                    _logger.LogException(e);
                }

                Thread.Sleep(1000);
            }

            _logger.Log("Monitoring complete!");
        }

        private bool IsUnacceptableTemperature(int temperature)
        {
            return temperature > 37;
        }

        private int GetTemperature()
        {
            return _random.Next(36, 40);
        }
    }
}