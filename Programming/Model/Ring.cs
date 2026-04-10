using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Ring
    {
        private Point2D centerCircle;
        private double radiusOuterCircle;
        private double radiusInnerCircle;

        public Point2D CenterCircle
        {
            get { return centerCircle; }
            set { centerCircle = value; }
        }

        public double RadiusOuterCircle
        {
            get { return radiusOuterCircle; }
            set
            {
                radiusOuterCircle = Validator.AssertOnPositiveValue(value, nameof(radiusOuterCircle));
            }
        }

        public double RadiusInnerCircle
        {
            get { return radiusInnerCircle; }
            set
            {
                radiusInnerCircle = Validator.AssertValueInRange(value, 0, radiusOuterCircle, nameof(radiusInnerCircle));
            }
        }

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
