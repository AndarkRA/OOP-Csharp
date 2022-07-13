using Homeworks_OOP;

/// <summary>
///  Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов). 
///  Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати. 
///  Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д. 
///  Предусмотреть возможность, чтобы уникальный номер здания генерировался программно. Для этого в классе предусмотреть статическое поле, 
///  которое бы хранило последний использованный номер здания, и предусмотреть метод, который увеличивал бы значение этого поля.
/// </summary>

Building building = new Building();
building.ChangeApartmentCount(10);
building.ChangeEntranceCount(12);
building.ChangeFloorCount(3);
building.ChangeHeight(125);

Console.WriteLine(building);
Console.WriteLine();
Console.WriteLine("Количество квартир на этаже: " + building.GetApartmentCountInFloor());
Console.WriteLine("Высота этажа: " + building.GetFloorHeight() + "м\n");

// убедимся, что id увеличивается

for (int i = 0; i < 100; i++)
{
    Building building2 = new Building();
    Console.WriteLine(building2.ID);
}

Console.ReadKey();
Console.ReadKey();
