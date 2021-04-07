using Bootcamp.DesignPatterns.Creational.FactoryMethod.Notifications.Notifiers;

namespace Bootcamp.DesignPatterns.Creational.FactoryMethod.Notifications.Factories
{
    public class EmailFactory : NotifierFactory
    {
        public EmailFactory(Notification notification) : base(notification)
        {
        }

        protected override Notifier CreateNotifier()
        {
            return new EmailNotifier();
        }
    }
}