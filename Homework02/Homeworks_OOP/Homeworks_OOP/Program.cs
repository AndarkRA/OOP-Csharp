using Homeworks_OOP;

/// <summary>
///  Создать класс рациональных чисел. В классе два поля – числитель и знаменатель. 
///  Предусмотреть конструктор. Определить операторы ==, != (метод Equals()), <, >, <=, >=, +, –, ++, --. 
///  Переопределить метод ToString() для вывода дроби. 
///  Определить операторы преобразования типов между типом дробь,float, int. Определить операторы *, /, %.
/// </summary>

RatioNumber number1 = new RatioNumber(5, 10);
RatioNumber number2 = new RatioNumber(2, 10);

Console.WriteLine(number1 == number2);
Console.WriteLine(number1 != number2);
Console.WriteLine(number1 < number2);
Console.WriteLine(number1 <= number2);
Console.WriteLine(number1 > number2);
Console.WriteLine(number1 >= number2);
Console.WriteLine($"{ number1}, {number2}");

//Console.Clear();
//float number3 = number1 * number2;
Console.WriteLine((number1 / number2).ToString());
Console.WriteLine((number1 % number2).ToString());

Console.ReadKey();
