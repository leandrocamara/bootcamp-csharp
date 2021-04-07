namespace Bootcamp.DesignPatterns.Creational.FactoryMethod.Notifications
{
    public class Notification
    {
        public NotificationType Type { get; }
        public string Message { get; }

        public Notification(NotificationType type, string message)
        {
            Type = type;
            Message = message;
        }
    }

    public enum NotificationType
    {
        Email,
        ConnectDirect,
        Nexxera
    }
}