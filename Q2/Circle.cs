using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Circle
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Circle()
        {
            Radius = 1;

        }

        public Circle (double radius)
        {
            Radius = radius;
        }

        public double getArea ()
        {
            return Math.PI * Radius * Radius;
        }


        public override string ToString()
        {
            return $"The radius is {Radius}";
        }
    }
}
