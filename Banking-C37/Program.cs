using Banking_C37;

Console.WriteLine("Banking!");

SavingComp saving2 = new();
saving2.AccountNo = 123;


Savings saving1 = new();
saving1.Deposit(1000);
saving1.Withdraw(500);
saving1.InterestRate = 0.12m;
saving1.CalcInterest(1);
Print(saving1);

Account checking = new Account();
checking.AccountNo = 100;
checking.Description = "My Checking Account";
checking.Balance = 0;

Account savings = new() {
    AccountNo = 200,
    Description = "My Savings Account",
    Balance = 0
};

checking.Deposit(500);
Print(checking);
savings.Deposit(20);
Print(savings);
checking.Withdraw(200);
Print(checking);
savings.Withdraw(5);
Print(savings);
checking.Transfer(250, savings);
Print(checking);
Print(savings);
checking.Withdraw(100);
Print(checking);
checking.Transfer(100, savings);
Print(checking);
Print(savings);




void Print(Account account) {
    Console.WriteLine($"{account.AccountNo} | {account.Description} | {account.Balance:C2}");
}
