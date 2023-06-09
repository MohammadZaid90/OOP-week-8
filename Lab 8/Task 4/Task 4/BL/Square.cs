using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.BL
{
    class Square:Shape
    {
        private double side;
        public Square(string type, double sides) : base(type)
        {
            this.side = sides;
        }
        public override double getArea()
        {
            return side * side;
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}
