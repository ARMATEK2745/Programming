using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop13.Model
{
    /// <summary>
    /// Проверяет значение на корректность
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Проверяет длину строки
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string AssertStringLength(string value, int maxLength)
        {
            if (value.Length <= maxLength) return value;
            throw new ArgumentException($"Длинна строки больше {maxLength}.");
        }

        /// <summary>
        /// Проверяет на то, положительное ли целочисленное число
        /// </summary>
        /// <param name="value"> проверяемое целочисленное число</param>
        /// <param name="propertyName"> Имя свойства</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"> Ошибка, если число не положительное</exception>
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
