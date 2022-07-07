using Homeworks_OOP;

BankAccount bankAccount = new BankAccount();
bankAccount.GetID();
bankAccount.Balance = 10000;
bankAccount.Type = AccountType.Debit;


Console.WriteLine($"Номер счета: {bankAccount.GetID()}\n" +
                  $"Баланс: {bankAccount.Balance}\n" +
                  $"Тип банковского счета: {bankAccount.Type}");
