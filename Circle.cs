using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObject
{
    internal class Circle
    {
        //properties

        private double radius;
        
        
        //constructors
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateDiameter()
        {
            return 2 * radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public void Double()
        {
            radius *= 2; // Double the radius
        }

        public double GetRadius()
        {
            return radius;
        }
    }
}
