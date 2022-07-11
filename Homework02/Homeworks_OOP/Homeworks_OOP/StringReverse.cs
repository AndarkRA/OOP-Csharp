

namespace Homeworks_OOP
{
    /// <summary>
    /// Реализовать метод, который в качестве входного параметра принимает строку string, 
    /// возвращает строку типа string, буквы в которой идут в обратном порядке. Протестировать метод
    /// </summary>
    public class StringReverse
    {
        public string StringChange(string somethingText)
        {
            char[] reverse = somethingText.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }
    }
}
