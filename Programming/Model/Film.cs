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
        private int releaseYear;
        private string genre = "";
        private double rating;


        public string Name { get { return name; } set { name = value; } }

        public int MinutesDuration
        {
            set {
                if (value >= 0) minutesDuration = value;
                else throw new ArgumentException(nameof(value),"Значение не может быть отрицательным");
            }
            get { return minutesDuration; }
        }

        public int ReleaseYear
        {
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                    releaseYear = value;
                else throw new ArgumentException(nameof(value),"Год выпуска должен быть в диапазоне от 1900 до текущего года");

            }
            get { return releaseYear; }
        }

        public string Genre { get { return genre; } set { genre = value; } }

        public double Rating
        {
            set 
            {
                if (value >= 0 && value <= 10) rating = value;
                else throw new ArgumentException(nameof(value),"Рейтинг должен быть в диапазоне от 0 до 10");
            }
            get { return rating; }
        }

        public Film(string name, int minutesDuration, int releaseYear, string genre, double rating)
        {
            Name = name;
            MinutesDuration = minutesDuration;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        public Film(){ }
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