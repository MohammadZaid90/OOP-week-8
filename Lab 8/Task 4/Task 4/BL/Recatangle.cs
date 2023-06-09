using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.BL
{
    class Rectangle:Shape
    {
        private double width;
        private double height;
        public Rectangle(string type, double w, double h) : base(type)
        {
            this.width = w;
            this.height = h;
        }
        public override double getArea()
        {
            return width * height;
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}
