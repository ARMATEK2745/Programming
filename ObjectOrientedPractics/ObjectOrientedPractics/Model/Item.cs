using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит Id, название, информацию и стоимость товара
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Счётчик Id товара
        /// </summary>
        private static int _idCounter;

        /// <summary>
        /// Id товара
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация товара 
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара 
        /// </summary>
        private double _cost;


        /// <summary>
        /// Возвращает Id товара
        /// </summary>
        public int Id { get { return _id; } init { _id = value; } }

        /// <summary>
        /// Возвращает и задаёт название товара
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (ValueValidator.AssertStringOnLength(value, 200, "Name"))
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт информацию товара
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }

            set
            {
                if (ValueValidator.AssertStringOnLength(value, 1000, "Info"))
                {
                    _info = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость товара
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }

            set
            {
                if (value < 0 ||  value > 100_000)
                {
                    throw new ArgumentException("Стоимость товара может быть от 0 до 100_000");
                }

                _cost = value;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Item
        /// </summary>
        public Item()
        {
            Id = _idCounter++;
            Name = "Defult";
            Info = "Defult";
            Cost = 0.0;
        }


        /// <summary>
        /// Инициализирует новый экземпляр класса Item
        /// </summary>
        /// <param name="name"> Название товара </param>
        /// <param name="info"> Информация товара </param>
        /// <param name="cost"> Стоимость товара </param>
        public Item(string name, string info, double cost)
        {
            Id = _idCounter++;
            Name = name;
            Info = info;
            Cost = cost;
        }

        
    }
}
