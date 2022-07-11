using Homeworks_OOP;

/// <summary>
///  В класс банковский счет, созданный в упражнениях, добавить метод, который переводит деньги с одного счета на другой. 
///  У метода два параметра: ссылка на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.
/// </summary>

var account = new BankAccount(1000, AccountType.Current);
Console.WriteLine(account);

var newAccount = new BankAccount(1000, AccountType.Current);
Console.WriteLine(newAccount);

account.Transaction(ref newAccount, 1000);
Console.WriteLine($"Переводим 1000 рублей со счета {newAccount.GetID()} на счет {account.GetID()}.");
Console.WriteLine(account);
Console.WriteLine(newAccount);

Console.WriteLine("=====================================");
StringReverse stringReverse = new();
Console.WriteLine($"{stringReverse.StringChange("Шла Саша по шоссе и сосала сушку")}");



Console.ReadKey();
