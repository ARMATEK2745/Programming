using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop13.Model
{
    static class Validator
    {
        public static string AssertStringLength(string value, int maxLength)
        {
            if (value.Length <= maxLength) return value;
            throw new ArgumentException($"Длинна строки больше {maxLength}.");
        }

        public static int AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Значение свойства '{propertyName}' должно быть положительным, получено {value}.");
            }
            return value;
        }
    }
}
