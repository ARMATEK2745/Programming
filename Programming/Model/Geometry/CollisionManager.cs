using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal static class CollisionManager
    {
        public static bool IsCollision(Rectangles rectangle1, Rectangles rectangle2)
        {
            double deltaX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double deltaY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            double sumHalfWidths = rectangle1.Width / 2 + rectangle2.Width / 2;
            double sumHalfLengths = rectangle1.Length / 2 + rectangle2.Length / 2;

            bool isCollidingX = deltaX < sumHalfWidths;
            bool isCollidingY = deltaY < sumHalfLengths;

            return isCollidingX && isCollidingY;

        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            if (
                Math.Pow(Math.Pow(ring1.CenterCircle.X - ring2.CenterCircle.X,2) + Math.Pow(ring1.CenterCircle.Y - ring2.CenterCircle.Y,2),0.5) < ring1.RadiusOuterCircle + ring2.RadiusOuterCircle
                )
            {
                return true;
            }
            return false;
        }   
    }
}
