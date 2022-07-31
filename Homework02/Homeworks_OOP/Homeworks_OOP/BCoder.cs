using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_OOP
{
    public class BCoder : ICoder
    {
        private const string UpperAlphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private const string DownerAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private string _upperString;
        private string _workAlphabet;
        private StringBuilder _sr;
        private bool _isFound;

        public string Decode(string baseString)
        {
            return Coding(baseString);
        }

        public string Encode(string baseString)
        {
            return Coding(baseString);
        }

        private string Coding(string baseString)
        {
            _sr = new StringBuilder();
            _upperString = baseString.ToUpper();
            for (int i = 0; i < baseString.Length; i++)
            {
                _isFound = false;
                // если символ равен символу в ToUpper строке, то мы имеем дело с UpperAlphabet. Иначе с DownerAlphabet.
                _workAlphabet = baseString[i] == _upperString[i] ? UpperAlphabet : DownerAlphabet;
                for (int j = 0; j < _workAlphabet.Length; j++)
                {
                    if (baseString[i] != _workAlphabet[j]) continue;
                    _sr.Append(_workAlphabet[_workAlphabet.Length - 1 - j]);
                    _isFound = true;
                    break;
                }
                // если в алфавитах ничего не нашли, то оставляем символ как есть
                if (!_isFound)
                {
                    _sr.Append(baseString[i]);
                }
            }
            return _sr.ToString();
        }
    }
}
