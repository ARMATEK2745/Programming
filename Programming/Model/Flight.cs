using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит в данные о рейсе
    /// </summary>
    internal class Flight
    {
        private string departurePoint = "";
        private string destination = "";
        private int minutesFlightTime;

        /// <summary>
        /// Возвращает и задаёт пункт вылета
        /// </summary>
        public string DeparturePoint { get { return departurePoint; } set { departurePoint = value; } }

        /// <summary>
        /// Возвращает и задаёт пункт назначения
        /// </summary>
        public string Destination { get { return destination; } set { destination = value; } }

        /// <summary>
        /// Возвращает и задаёт время рейса.
        /// </summary>
        public int MinutesFlightTime
        {
            set
            {
                minutesFlightTime = Validator.AssertOnPositiveValue(value, nameof(minutesFlightTime));
            }
            get { return minutesFlightTime; }
        }

        public Flight(string departurePoint, string destination, int minutesFlightTime)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            MinutesFlightTime = minutesFlightTime;
        }

        public Flight() { }
    }
}
// Класс Рейс
// Начало описания класса
// Строковое поле Пункт Вылета
// Строковое поле Пункт назначения
// Целочисленное поле Время полета в минутах
// Конец описания класса