using System.Collections.Generic;
using Bootcamp.SOLID.DIP.Correct.ActionsAfterGenerateInvoice;

namespace Bootcamp.SOLID.DIP.Correct
{
    /// <summary>
    /// Dependecy Inversion Principle - Correct Example
    /// </summary>
    public class InvoiceGenerator
    {
        private readonly IList<IActionAfterGenerateInvoice> _actions;

        public InvoiceGenerator(IList<IActionAfterGenerateInvoice> actions)
        {
            _actions = actions;
        }

        public Invoice Generate(double value)
        {
            var invoice = new Invoice(value, GetSimplexTax(value));

            foreach (var action in _actions)
                action.Execute(invoice);

            return invoice;
        }

        private double GetSimplexTax(double value) => value * 0.06;
    }
}