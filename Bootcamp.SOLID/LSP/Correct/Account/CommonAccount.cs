namespace Bootcamp.SOLID.LSP.Correct.Account
{
    public class CommonAccount
    {
        private readonly BalanceHandler _balanceHandler;

        public CommonAccount()
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

        public void Yield()
        {
            _balanceHandler.Yield(0.1);
        }
    }
}