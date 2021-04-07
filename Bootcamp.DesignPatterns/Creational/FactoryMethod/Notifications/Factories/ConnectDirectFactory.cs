using Bootcamp.DesignPatterns.Creational.FactoryMethod.Notifications.Notifiers;

namespace Bootcamp.DesignPatterns.Creational.FactoryMethod.Notifications.Factories
{
    public class ConnectDirectFactory : NotifierFactory
    {
        public ConnectDirectFactory(Notification notification) : base(notification)
        {
        }

        protected override Notifier CreateNotifier()
        {
            return new ConnectDirectNotifier();
        }
    }
}