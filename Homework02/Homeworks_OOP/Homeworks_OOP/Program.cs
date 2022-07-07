using Homeworks_OOP;

BankAccount bankAccount = new BankAccount(35, AccountType.Debit);
bankAccount.AddBalance(1000);




Console.WriteLine(bankAccount.Print());

if (!bankAccount.PullBalance(500))
	Console.WriteLine("Недостаточно средств!");
