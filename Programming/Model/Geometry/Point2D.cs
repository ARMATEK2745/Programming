using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Geometry
{
    internal class Point2D
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            private set
            {
                x = value;
            }
        }

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
