using Homeworks_OOP;



ACoder aCoder = new ACoder();
var a = aCoder.Encode("Съешь ещё этих мягких французских булок да выпей же чаю.");
Console.WriteLine(a);
//Тыёщэ ёъж юуйц надлйц хсбочфитлйц вфмпл еб гьрёк зё шбя.
Console.WriteLine(aCoder.Decode(a));
//Съешь ещё этих мягких французских булок да выпей же чаю.

BCoder bCoder = new BCoder();
var b = bCoder.Encode("Эй, жлоб! Где туз? Прячь юных съёмщиц в шкаф.");
Console.WriteLine(b);
//Вх, шурю! Ьыъ млч? Поазг бсдй нещтёци э жфяк.
Console.WriteLine(bCoder.Decode(b));
//Эй, жлоб! Где туз? Прячь юных съёмщиц в шкаф.

Console.ReadKey();
