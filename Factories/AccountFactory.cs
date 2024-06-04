using ATMApp.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Factories
{
    // Factory Method - Detta blir basen för att skapa olika typer av bank konton
    public abstract class AccountFactory
    {
        public abstract BankAccount CreateAccount(string accountNumber);
    }
}
