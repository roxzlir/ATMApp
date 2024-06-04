using ATMApp.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Strategys
{
    // Strategy - kan alltså bygga ut med fler uttags tjänster, tex en med AbroadWithdrawl om man är utomlands
    public class NormalWithdrawal : IWithdrawalStrategy
    {
        public bool Withdraw(BankAccount account, decimal amount)
        {
            return account.Withdraw(amount);
        }
    }
}
