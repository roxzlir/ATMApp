using ATMApp.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Factories
{
    // Factory Method - kan med lätthet utöka med factory om jag vill skapa fler typ av konton utan att röra befintliga
    public class CheckingAccountFactory : AccountFactory
    {
        public override BankAccount CreateAccount(string accountNumber)
        {
            return new CheckingAccount(accountNumber);
        }
    }
}
