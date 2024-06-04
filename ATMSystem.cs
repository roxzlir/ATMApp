using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMApp.Accounts;

namespace ATMApp
{
    // Singleton - Här säkerställer jag så det bara körs 1 instans av själva bankomat systemet då enligt Singelton principen!
    public class ATMSystem
    {
        private static ATMSystem _instance;
        private Dictionary<string, BankAccount> _accounts;

        private ATMSystem()
        {
            _accounts = new Dictionary<string, BankAccount>();
        }

        public static ATMSystem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ATMSystem();
                }
                return _instance;
            }
        }

        public void AddAccount(BankAccount account)
        {
            _accounts[account.AccountNumber] = account;
        }

        public BankAccount GetAccount(string accountNumber)
        {
            _accounts.TryGetValue(accountNumber, out BankAccount account);
            return account;
        }
        public void DisplayAccountList()
        {
            if (_accounts.Count == 0)
            {
                Console.WriteLine("There is no accounts registered yet.");
                return;
            }
            foreach (var account in _accounts.Values)
            {
                Console.Clear();
                Console.WriteLine($"Account number: {account.AccountNumber} - Account type: {account.AccountType()} - Current balance:  Balance: {account.Balance}\n");
            }
        }
    }
}
