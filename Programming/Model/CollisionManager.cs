using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal static class CollisionManager
    {
        public static bool IsCollision(Rectangles rectangle1, Rectangles rectangle2)
        {
            if (
                rectangle1.Center.setX - rectangle2.Center.setX < Math.Abs(rectangle1.Width - rectangle2.Width) / 2
                && rectangle1.Center.setY - rectangle2.Center.setY < Math.Abs(rectangle1.Length - rectangle2.Length) / 2
                )
            {
                return true;
            }

            else { return false; }
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            if (
                Math.Pow(Math.Pow((ring1.CenterCircle.setX - ring2.CenterCircle.setX),2) + Math.Pow((ring1.CenterCircle.setY - ring2.CenterCircle.setY),2),0.5) < (ring1.RadiusOuterCircle + ring2.RadiusOuterCircle)
                )
            {
                return true;
            }
            return false;
        }   
    }
}
