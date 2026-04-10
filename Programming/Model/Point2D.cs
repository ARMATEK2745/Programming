using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model
{
    internal class Point2D
    {
        private double x;
        private double y;

        public double setX
        {
            get { return x; }
            private set
            {
             x = value;
            }
        }

        public double setY
        {
            get { return y; }
            private set
            {
             y = value;
            }
        }

        public Point2D(double x, double y)
        {
            setX = x;
            setY = y;
        }

        public Point2D() { }
    }
}
