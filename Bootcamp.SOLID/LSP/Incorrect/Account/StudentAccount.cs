using System;

namespace Bootcamp.SOLID.LSP.Incorrect.Account
{
    public class StudentAccount : CommonAccount
    {
        public override void Yield()
        {
            throw new NotSupportedException();
        }
    }
}