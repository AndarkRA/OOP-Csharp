using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_OOP
{
    enum AccountType
    {
        Credit,
        Debit,
        Current
    }

    /// <summary>
    /// Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
    /// банковского счета(использовать перечислимый тип). Предусмотреть методы для
    /// доступа к данным – заполнения и чтения.Создать объект класса, заполнить его
    /// поля и вывести информацию об объекте класса на печать
    /// </summary>
    internal class BankAccount
    {
        public override string ToString() => $"[{BankNumber}] ({Balance}) {Type}";

        private int _bankNumber;
        private decimal _balance;
        private AccountType _type;


        public int BankNumber
        {
           get => _bankNumber;
           set => _bankNumber = value;
        }

        public decimal Balance
        {
            get => _balance;
            set => _balance = value;
        }

        public AccountType Type
        {
            get => _type;
            set => _type = value;
        }

    }
}
