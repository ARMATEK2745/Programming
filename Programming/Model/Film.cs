using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Film
    {
        private string name = "";
        private int minutesDuration;
        private int releaseYear
        {
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                    releaseYear = value;
                else
                    Console.WriteLine("Год выпуска должен быть в диапазоне от 1900 до текущего года");

            }
            get { return releaseYear; }
        }
        private string genre = "";
        private double rating
        {
            set 
            {
                if (value >= 0 && value <= 10) rating = value;
                else Console.WriteLine("Рейтинг должен быть в диапазоне от 0 до 10");
            }
            get { return rating; }
        }
    }
}
// Класс Фильм
// Начало описания класса
// Строковое поле Название
// Целочисленное поле Продолжительность в минутах
// Целочисленное поле Год выпуска (от 1900 до текущего года)
// Строковое поле Жанр
// Вещественное поле Рейтинг (от 0 до 10)
// Конец описания класса