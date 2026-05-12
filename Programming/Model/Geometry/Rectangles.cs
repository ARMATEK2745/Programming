using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal class Rectangles
    {
        private int _id;
        private double length;      //длина
        private double width;       //ширина
        private string colour = ""; //цвет
        private static int _allRectanglesCount = 0;
        private Point2D center;


        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

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

        public static int AllRectanglesCount()
        {
            return _allRectanglesCount;
        }


        public Point2D Center { get; set; }



        public Rectangles(string name, double length, double width, string colour, Point2D center)
        {
            Name = name;
            Length = length;
            Width = width;
            Colour = colour;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangles() { _allRectanglesCount++; _id = _allRectanglesCount; }

        public static Rectangles RandomRectangle(double minWidth, double maxWidth, double minLength, double maxLength, double minX, double maxX, double minY, double maxY)
        {
            Random rand = new Random();
            int colorCount = Enum.GetNames(typeof(Colors)).Length;

            double width = minWidth + rand.NextDouble() * (maxWidth - minWidth);
            double length = minLength + rand.NextDouble() * (maxLength - minLength);
            string randomColor = ((Colors)rand.Next(colorCount)).ToString();

            minX += width / 2;
            maxX -= width / 2;
            minY += length / 2;
            maxY -= length / 2;

            Point2D center = new Point2D(
                minX + rand.NextDouble() * (maxX - minX),
                minY + rand.NextDouble() * (maxY - minY)
            );

            Rectangles rectangle = new Rectangles("", length, width, randomColor, center);
            return rectangle;
        }
    }
}
// Класс Прямоугольник
// Начало описания класса
// Вещественное поле Длина
// Вещественное поле Ширина
// Строковое поле Цвет
// Конец описания класса