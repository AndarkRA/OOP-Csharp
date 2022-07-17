using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_OOP
{
    public enum AccountType
    {
        Credit,
        Debit,
        Current
    }


    internal class BankAccount
    {
        //public override string ToString() => $"[{GetID}] ({_balance}) {_type} {_bankNumber}";


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

        public void PutMoney(decimal money)
        {
            _balance += money;
        }

        public decimal GetMoney(decimal money)
        {
            if (_balance < money) return 0;
            _balance -= money;
            return money;
        }

        public bool Transaction(ref BankAccount bankAccount, decimal money)
        {
            bankAccount.GetMoney(money);
            this.PutMoney(money);
            return true;
        }
        //public override string ToString()
        //{
        //    return $"Номер счета: [{GetID()}];\n Тип счета: {_type};\n Остаток на текущий момент, руб.: {_balance}.";
        //}

        /// <summary>
        /// Для класса банковский счет переопределить операторы == и != для сравнения информации в двух счетах. 
        /// Переопределить метод Equals аналогично оператору ==, не забыть переопределить метод GetHashCode(). 
        /// Переопределить методToString() для печати информации о счете. 
        /// Протестировать функционирование переопределенных методов и операторов на простом примере.
        /// </summary>
        public override string ToString()
        {
            return $"Счёт номер\t{GetID()}\nБаланс\t\t{_balance}\nТип\t\t{_type}\n";
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(GetID());
            hash.Add(_balance);
            hash.Add(_type);
            return hash.ToHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj is not BankAccount)
            {
                return false;
            }
            return this == (BankAccount)obj;
        }

    }
}
