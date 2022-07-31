using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_OOP
{
    public class ACoder : ICoder
    {
        private const string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private StringBuilder _sr;
        private bool _isFound;
        public int Step { get; set; }

        public ACoder() : this(1)
        {
        }

        public ACoder(int step)
        {
            Step = step;
        }

        public string Decode(string baseString)
        {
            return Coding(baseString, -Step);
        }

        public string Encode(string baseString)
        {
            return Coding(baseString, Step);
        }

        private string Coding(string baseString, int correct)
        {
            _sr = new StringBuilder();

            for (int i = 0; i < baseString.Length; i++)
            {
                _isFound = false;

                for (int j = 0; j < Alphabet.Length; j++)
                {
                    if (baseString[i] != Alphabet[j]) continue;
                    _sr.Append(Alphabet[GetIndex(j, correct % 33)]);
                    _isFound = true;
                    break;
                }
                // если в алфавите ничего не нашли, то оставляем символ как есть
                if (!_isFound)
                {
                    _sr.Append(baseString[i]);
                }
            }
            return _sr.ToString();
        }

        private int GetIndex(int index, int correct)
        {
            if ((index + correct) / 33 > index / 33)
            {
                index -= 33;
            }
            else if (index + correct < 0 || (index + correct) / 33 < index / 33)
            {
                index += 33;
            }

            return index + correct;
        }
    }
}
