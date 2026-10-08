using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Item
    {
        private static int _idCounter;
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        public int Id { get { return _id; } init { _id = value; } }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value.Length > 200)
                {
                    throw new ArgumentException("Название может быть не больше 200 символов.");
                }
            }
        }

        public string Info
        {
            get
            {
                return _info;
            }

            set
            {
                if (value.Length > 1000)
                {
                    throw new ArgumentException("Название может быть не больше 200 символов.");
                }
            }
        }

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
            }
        }

        public Item(string name, string info, double cost)
        {
            Id = _idCounter++;
            Name = name;
            Info = info;
            Cost = cost;
        }

    }
}
