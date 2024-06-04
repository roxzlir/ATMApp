using ATMApp.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Strategys
{
    // Strategy - kan alltså bygga ut med fler uttags tjänster, tex en med AbroadWithdrawl om man är utomlands
    public class FastWithdrawal : IWithdrawalStrategy
    {
        public bool Withdraw(BankAccount account, decimal amount)
        {
            // Bara för det ska vara någon skillnad så sätter jag att man max får ta ut under 1000 på ett snabbt uttag
            if (amount > 1000)
            {
                Console.WriteLine("Fast withdrawal limit is 1000");
                return false;
            }
            return account.Withdraw(amount);
        }
    }
}
