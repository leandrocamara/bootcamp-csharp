using System.Collections.Generic;
using Bootcamp.DesignPatterns.Creational.FactoryMethod.Notifications;
using Bootcamp.DesignPatterns.Creational.FactoryMethod.Notifications.Factories;

namespace Bootcamp.DesignPatterns.Creational.FactoryMethod
{
    public class FactoryMethodApp
    {
        public static void Execute()
        {
            var notifications = new List<Notification>
            {
                new(NotificationType.Email, "Email A"),
                new(NotificationType.ConnectDirect, "File X"),
                new(NotificationType.Nexxera, "File Y")
            };

            notifications.ForEach(notification => NotifierFactory.Create(notification).Send());
        }
    }
}