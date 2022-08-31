using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_C37 {
    
    public class SavingComp {

        private Account account = new();

        public int AccountNo { 
            get { return account.AccountNo; } 
            set { account.AccountNo = value; }
        }
        public string Description {
            get { return account.Description; }
            set { account.Description = value; }
        }
        public decimal Balance {
            get { return account.Balance;  }
            set { account.Balance = value; }
        }

        public bool Deposit(decimal Amount) {
            return account.Deposit(Amount);
        }
        public bool Withdraw(decimal Amount) {
            return account.Withdraw(Amount);
        }
        public bool Transfer(decimal Amount, Account ToAccount) {
            return account.Transfer(Amount, ToAccount);
        }
    }
}
