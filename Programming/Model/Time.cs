using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public int Hours
        {
            set
            {
                if (value >= 0 && value <= 23) hours = value;
                else throw new ArgumentException(nameof(value), "Час должен быть в диапаоне от 0 до 23");
            }
            get { return hours; }

        }

        public int Minutes
        {
            set
            {
                if (value >= 0 && value <= 60) minutes = value;
                else throw new ArgumentException(nameof(value), "Минуты должны быть в диапаоне от 0 до 60");
            }
            get { return minutes; }
        }

        public int Seconds
        {
            set
            {
                if (value >= 0 && value <= 60) seconds = value;
                else throw new ArgumentException(nameof(value), "Секунды должны быть в диапаоне от 0 до 60");
            }
            get { return seconds; }
        }

        public Time(int hours, int minutes, int seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public Time() { }
    }
}
// Класс Время
// Начало описания класса
// Целочисленное поле Часы (от 0 до 23)
// Целочисленное поле Минуты (от 0 до 60)
// Целочисленное поле Секунды (от 0 до 60)
// Конец описания класса