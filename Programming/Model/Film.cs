using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о фильме
    /// </summary>
    internal class Film
    {
        private string name = "";
        private int minutesDuration;
        private int releaseYear;
        private string genre = "";
        private double rating;

        /// <summary>
        /// Возвращает и задаёт название фильма
        /// </summary>
        public string Name { get { return name; } set { name = value; } }

        /// <summary>
        /// Возвращает и задаёт продолжительность
        /// </summary>
        public int MinutesDuration
        {
            set 
            {
                minutesDuration = Validator.AssertOnPositiveValue(value, nameof(minutesDuration));
            }
            get { return minutesDuration; }
        }


        /// <summary>
        /// Возвращает и задаёт год выпуска
        /// </summary>
        public int ReleaseYear
        {
            set
            {
                releaseYear = Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(releaseYear));
            }
            get { return releaseYear; }
        }

        /// <summary>
        /// Возвращает и задаёт жанр
        /// </summary>
        public string Genre { get { return genre; } set { genre = value; } }

        /// <summary>
        /// Возвращает и задаёт рейтинг
        /// </summary>
        public double Rating
        {
            set 
            {
                rating = Validator.AssertValueInRange(value, 1, 10, nameof(rating));
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