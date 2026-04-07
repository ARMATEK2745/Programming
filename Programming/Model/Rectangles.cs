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
                length = Validator.AssertOnPositiveValue(value, nameof(length));
            }
            get { return length; }
        }

        public double Width
        {
            set
            {
                width = Validator.AssertOnPositiveValue(value, nameof(width));
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