using ATMApp.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Strategys
{
    // Strategy - Vill kunna skapa flera olika uttags möjligheter, så här är mitt Interface som jag har som bas till detta
    public interface IWithdrawalStrategy
    {
        bool Withdraw(BankAccount account, decimal amount);
    }
}
