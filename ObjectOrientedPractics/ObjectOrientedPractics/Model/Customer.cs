using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит Id, полное имя и адрес покупателя
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Счётчик Id покуателя
        /// </summary>
        private static int _idCounter;

        /// <summary>
        /// Id покупателя
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес покупателя
        /// </summary>
        private string _address;


        /// <summary>
        /// Возвращает айди покупателя
        /// </summary>
        public int Id { get { return _id; } init { _id = value; } }


        /// <summary>
        /// Возвращает и задаёт полное имя покупателя
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }

            set
            {
                if (ValueValidator.AssertStringOnLength( value , 200 , "Fullname"))
                {
                    _fullname = value;
                }
            }
        }


        /// <summary>
        /// Возвращает и задаёт адрес покупателя
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                if (ValueValidator.AssertStringOnLength(value, 500, "Address"))
                {
                    _address = value;
                }
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Customer
        /// </summary>
        public Customer()
        {
            Id = _idCounter++;
            Fullname = "Defult";
            Address = "Defult";
        }


        /// <summary>
        /// Инициализирует новый экземпляр класса Customer
        /// </summary>
        /// <param name="fullname"> Полное имя покупателя </param>
        /// <param name="address"> Адрес покупателя </param>
        public Customer(string fullname, string address)
        {
            Id = _idCounter++;
            Fullname = fullname;
            Address = address;
        }

    }
}
