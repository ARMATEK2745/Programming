using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит в себе информацию о кольце
    /// </summary>
    internal class Ring
    {
        private Point2D centerCircle;
        private double radiusOuterCircle;
        private double radiusInnerCircle;

        /// <summary>
        /// Возвращает и задаёт значение координат кольца
        /// </summary>
        public Point2D CenterCircle
        {
            get { return centerCircle; }
            set { centerCircle = value; }
        }

        /// <summary>
        /// Возвращает и задаёт значение внешнего радиуса кольца
        /// </summary>
        public double RadiusOuterCircle
        {
            get { return radiusOuterCircle; }
            set
            {
                radiusOuterCircle = Validator.AssertOnPositiveValue(value, nameof(radiusOuterCircle));
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение внутреннего радиуса кольца
        /// </summary>
        public double RadiusInnerCircle
        {
            get { return radiusInnerCircle; }
            set
            {
                radiusInnerCircle = Validator.AssertValueInRange(value, 0, radiusOuterCircle, nameof(radiusInnerCircle));
            }
        }

        /// <summary>
        /// Возвращает площадь кольца между внутренней и внешней частью
        /// </summary>
        public double Area
        {
            get { return Math.PI * Math.Pow(radiusOuterCircle, 2) - Math.PI * Math.Pow(radiusInnerCircle, 2); }
        }

        public Ring(Point2D centerCircle, double radiusOuterCircle, double radiusInnerCircle)
        {
            CenterCircle = centerCircle;
            RadiusOuterCircle = radiusOuterCircle;
            RadiusInnerCircle = radiusInnerCircle;
        }

        public Ring() { }
    }
}
