namespace Bootcamp.SOLID.DIP.Correct.ActionsAfterGenerateInvoice
{
    public class EmailSender : IActionAfterGenerateInvoice
    {
        public void Execute(Invoice invoice)
        {
            // ...
        }
    }
}