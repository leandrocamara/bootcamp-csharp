using System;
using System.Linq;

namespace Bootcamp.DesignPatterns.Structural.Facade.CrossCutting
{
    public interface IConfigurationManager
    {
        string GetValue(string node);
    }

    public class ConfigurationManager : IConfigurationManager
    {
        public string GetValue(string node)
        {
            return new(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}