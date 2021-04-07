namespace Bootcamp.DesignPatterns.Creational.Singleton
{
    public class SingletonApp
    {
        public static void Execute()
        {
            Database.GetInstance().Execute("SELECT * FROM CUSTOMERS;");
            Database.GetInstance().Execute("SELECT TOP 10 * FROM PRODUCTS;");
        }
    }
}