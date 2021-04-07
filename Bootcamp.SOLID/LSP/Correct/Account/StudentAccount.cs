namespace Bootcamp.SOLID.LSP.Correct.Account
{
    public class StudentAccount
    {
        private readonly BalanceHandler _balanceHandler;

        public StudentAccount()
        {
            _balanceHandler = new BalanceHandler();
        }

        public void Deposit(double value)
        {
            _balanceHandler.Add(value);
        }

        public void Withdraw(double value)
        {
            _balanceHandler.Remove(value);
        }

        // Doesn't implement the 'Yield' method.
    }
}