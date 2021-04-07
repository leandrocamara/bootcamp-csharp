namespace Bootcamp.SOLID.DIP.Correct.ActionsAfterGenerateInvoice
{
    public interface IActionAfterGenerateInvoice
    {
        void Execute(Invoice invoice);
    }
}