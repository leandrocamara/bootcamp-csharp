using Bootcamp.DesignPatterns.Creational.FactoryMethod.Notifications.Notifiers;

namespace Bootcamp.DesignPatterns.Creational.FactoryMethod.Notifications.Factories
{
    public class NexxeraFactory : NotifierFactory
    {
        public NexxeraFactory(Notification notification) : base(notification)
        {
        }

        protected override Notifier CreateNotifier()
        {
            return new NexxeraNotifier();
        }
    }
}