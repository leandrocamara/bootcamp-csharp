using System;
using Bootcamp.DesignPatterns.Creational.FactoryMethod.Notifications.Notifiers;

namespace Bootcamp.DesignPatterns.Creational.FactoryMethod.Notifications.Factories
{
    public abstract class NotifierFactory
    {
        protected NotifierFactory(Notification notification)
        {
            Notification = notification;
        }

        protected abstract Notifier CreateNotifier(); // Factory Method

        public Notification Notification { get; }

        public void Send()
        {
            CreateNotifier().Send(Notification.Message);
        }

        public static NotifierFactory Create(Notification notification)
        {
            return notification.Type switch
            {
                NotificationType.Email => new EmailFactory(notification),
                NotificationType.ConnectDirect => new ConnectDirectFactory(notification),
                NotificationType.Nexxera => new NexxeraFactory(notification),
                _ => throw new ArgumentException($"Invalid Notification Type: {notification.Type}")
            };
        }
    }
}