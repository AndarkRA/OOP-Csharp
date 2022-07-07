using Homeworks_OOP;

BankAccount bankAccount = new BankAccount();
bankAccount.BankNumber = 1412344;
bankAccount.Balance = 10000;
bankAccount.Type = AccountType.Debit;


Console.WriteLine($"Номер счета: {bankAccount.BankNumber}\n" +
                  $"Баланс: {bankAccount.Balance}\n" +
                  $"Тип банковского счета: {bankAccount.Type}");
