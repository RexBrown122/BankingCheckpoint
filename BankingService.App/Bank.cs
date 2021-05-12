using System.Collections.Generic;

namespace BankingService {
    public class Bank {
        public List<Account> Accounts;

        public void AddAccount(Account account) {
            Accounts.Add(account);
        }

        public Bank() {
            Accounts = new List<Account>();
        }
    }
}