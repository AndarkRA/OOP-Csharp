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
    /// В классе банковский счет, удалить методы заполнения полей. Вместо этих
    /// методов создать конструкторы.Переопределить конструктор по умолчанию,
    /// создать конструктор для заполнения поля баланс, конструктор для заполнения
    /// поля тип банковского счета, конструктор для заполнения баланса и типа
    /// банковского счета.Каждый конструктор должен вызывать метод, генерирующий
    /// номер счета.
    /// </summary>
    internal class BankAccount
    {
        public override string ToString() => $"[{GetID}] ({_balance}) {_type} {_bankNumber}";


        static int ID;

        private int _bankNumber;
        private decimal _balance;
        private AccountType _type;


        public BankAccount() { _bankNumber = GetID(); }
        public BankAccount(decimal balance) { _balance = balance; _bankNumber = GetID(); }

        public BankAccount(AccountType type) { _type = type; GetID(); }

        public BankAccount(decimal balance, AccountType type) {_balance = balance; _type = type; GetID(); }


        Random rnd = new Random();
        public int GetID()
        {
            if (_bankNumber == 0)
                _bankNumber = rnd.Next(0, 1000000);
            return _bankNumber;
        }

        public static int NewID()
        {
            return ++ID;
        }
        public string Print()
        {
            return $"Account number: {_bankNumber}{Environment.NewLine}Account type: {AccountType.Debit}{Environment.NewLine}Balance: {_balance}";
        }

        public void AddBalance(decimal money)
        {
            _balance += money;
        }
        public bool PullBalance(decimal money)
        {
            if (_balance >= money)
            {
                _balance -= money;
                return true;
            }
            return false;
        }
    }
}
