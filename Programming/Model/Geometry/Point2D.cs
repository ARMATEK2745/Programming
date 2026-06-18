using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит координаты X и Y
    /// </summary>
    internal class Point2D
    {
        private double x;
        private double y;

        /// <summary>
        /// Возвращает и задаёт значение координаты X
        /// </summary>
        public double X
        {
            get { return x; }
            private set
            {
                x = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение координаты Y
        /// </summary>
        public double Y
        {
            get { return y; }
            private set
            {
                y = value;
            }
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point2D() { }

        public void SetX(double x)
        {
            X = x;
        }

        public void SetY(double y) 
        { 
            Y = y;
        }
    }
}
