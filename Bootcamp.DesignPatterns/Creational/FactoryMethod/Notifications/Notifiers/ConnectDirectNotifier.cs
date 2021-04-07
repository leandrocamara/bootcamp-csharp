using System;

namespace Bootcamp.DesignPatterns.Creational.FactoryMethod.Notifications.Notifiers
{
    public class ConnectDirectNotifier : Notifier
    {
        public override void Send(string message)
        {
            Console.WriteLine($"{message} sent by ConnectDirect.");
        }
    }
}