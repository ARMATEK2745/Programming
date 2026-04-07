using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                hours = Validator.AssertValueInRange(value, 0, 23, nameof(hours));
            }
            get { return hours; }

        }

        public int Minutes
        {
            set
            {
                minutes = Validator.AssertValueInRange(value, 0, 60, nameof(minutes));
            }
            get { return minutes; }
        }

        public int Seconds
        {
            set
            {
                seconds = Validator.AssertValueInRange(value, 0, 60, nameof(seconds));
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