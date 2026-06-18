using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Validator
    {
        /// <summary>
        /// Проверяет на то, положительное ли целочисленное число
        /// </summary>
        /// <param name="value"> проверяемое целочисленное число</param>
        /// <param name="propertyName"> Имя свойства</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"> Ошибка, если число не положительное</exception>
        public static int AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение свойства '{propertyName}' должно быть положительным, получено {value}.");
            }
            return value;
        }

        /// <summary>
        /// Проверяет на то, положительное ли вещественное число
        /// </summary>
        /// <param name="value">Проверяемое вещественное число</param>
        /// <param name="propertyName">Имя свойства</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Ошибка, если число не положительное</exception>
        public static double AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение свойства '{propertyName}' должно быть положительным, получено {value}.");
            }
            return value;
        }

        /// <summary>
        /// Проверяет, находится ли целочисленное число в диапазоне
        /// </summary>
        /// <param name="value">Проверяем число</param>
        /// <param name="min">Начало диапазона</param>
        /// <param name="max">Конец диапазона</param>
        /// <param name="propertyName">Имя свойства</param>
        /// <returns>Возвращает true, если число находится в диапазоне</returns>
        /// <exception cref="ArgumentException">Ошибка, если число не находится в диапазоне</exception>
        public static int AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение свойства '{propertyName}' должно быть в диапазоне от {min} до {max}, получено {value}.");
            }
            return value;
        }

        /// <summary>
        /// Проверяет, находится ли вещественное число в диапазоне
        /// </summary>
        /// <param name="value">Проверяем число</param>
        /// <param name="min">Начало диапазона</param>
        /// <param name="max">Конец диапазона</param>
        /// <param name="propertyName">Имя свойства</param>
        /// <returns>Возвращает true, если число находится в диапазоне</returns>
        /// <exception cref="ArgumentException">Ошибка, если число не находится в диапазоне</exception>
        public static double AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение свойства '{propertyName}' должно быть в диапазоне от {min} до {max}, получено {value}.");
            }
            return value;
        }
    }
}