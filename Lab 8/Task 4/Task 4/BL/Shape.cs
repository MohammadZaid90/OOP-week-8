using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.BL
{
    class Shape
    {
        protected string type;
        protected double Area = 0.00000;
        public Shape(string type)
        {
            this.type = type;
        }
        public virtual double getArea()
        {
            return Area;
        }
        public virtual string toString()
        {
            return "The Shape is " + type + " & its Area is " + getArea();
        }
    }
}
