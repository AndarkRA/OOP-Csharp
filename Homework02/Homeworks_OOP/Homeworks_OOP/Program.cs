using Homeworks_OOP;



var account1 = new BankAccount(100);
var account2 = new BankAccount(5000);

Console.WriteLine(account1);
Console.WriteLine(account2);

Console.WriteLine($"Transaction success: {account1.Transaction(ref account2, 5000)}\n");

Console.WriteLine(account1.Equals(account2));
Console.WriteLine(account2.Equals(account2));

Console.WriteLine(account1 == account2);
Console.WriteLine(account1 != account2);

Console.ReadKey();
