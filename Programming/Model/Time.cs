using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Time
    {
        private int hours
        {
            set 
            {
                if (value >= 0 && value <= 23) hours = value;
                else Console.WriteLine("Час должен быть в диапаоне от 0 до 23");
            }

        }
    }
}
// Класс Время
// Начало описания класса
// Целочисленное поле Часы (от 0 до 23)
// Целочисленное поле Минуты (от 0 до 60)
// Целочисленное поле Секунды (от 0 до 60)
// Конец описания класса