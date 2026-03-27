using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Rectangles
    {
        private double length;      //длина
        private double width;       //ширина
        private string colour = ""; //цвет

        public string Name { get; set; }

        public double Length
        {
            set
            {
                if (value >= 0) length = value;
                else throw new ArgumentException(nameof(value), "Значение не может быть отрицательным");
            }
            get { return length; }
        }

        public double Width
        {
            set
            {
                if (value >= 0) width = value;
                else throw new ArgumentException(nameof(value), "Значение не может быть отрицательным");
            }
            get { return width; }
        }

        public string Colour { get { return colour; } set { colour = value; } }

        public Rectangles(string name, double length, double width, string colour)
        {   
            Name = name;
            Length = length;
            Width = width;
            Colour = colour;
        }

        public Rectangles() { }
    }
}
// Класс Прямоугольник
// Начало описания класса
// Вещественное поле Длина
// Вещественное поле Ширина
// Строковое поле Цвет
// Конец описания класса