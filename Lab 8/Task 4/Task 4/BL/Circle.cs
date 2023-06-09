using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.BL
{
    class Circle:Shape
    {
        private double radius;
        public Circle(string type, double radius) : base(type)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            return (2 * 3.14 * (radius * radius));
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}
