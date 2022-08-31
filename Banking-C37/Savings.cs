using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_C37 {
    
    public class Savings : Account {

        public decimal InterestRate { get; set; } = 0.01m;

        public decimal CalcInterest(int months) {
            decimal InterestAmount =  Balance * (InterestRate / 12) * months;
            Deposit(InterestAmount);
            return InterestAmount;
        }
    }
}
