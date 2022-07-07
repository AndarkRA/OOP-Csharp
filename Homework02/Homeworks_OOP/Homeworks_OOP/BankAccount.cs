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
    /// Изменить класс счет в банке из упражнения таким образом, чтобы номер счета
    /// генерировался сам и был уникальным.Для этого надо создать в классе
    /// статическую переменную и метод, который увеличивает значение этого
    /// переменной.
    /// </summary>
    internal class BankAccount
    {
        public override string ToString() => $"[{GetID}] ({Balance}) {Type}";
        Random rnd = new Random();

        static int ID;

        private int _bankNumber;
        private decimal _balance;
        private AccountType _type;



        public decimal GetID()
        {
            if (_bankNumber == 0)
                _bankNumber = rnd.Next(0, 1000000);
            return _bankNumber;
        }
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
        public static decimal NewID()
        {
            return ++ID;
        }
    }
}
