using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Circle
    {
        private double radius = 1.0;
        private string color = "red";

        public Circle()
        {
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public virtual double getRadius()
        {
            return this.radius;
        }

        public virtual void setRadius(double radius)
        {
            this.radius = radius;
        }

        public virtual string getColor()
        {
            return this.color;
        }

        public virtual void setColor(string color)
        {
            this.color = color;
        }

        public virtual double getArea()
        {
            double area = 3.14 * this.radius * this.radius;
            return area;
        }

        public virtual string toString()
        {
            return "Circle[radius = " + radius + " , colour = " + color +  " ,area = " + getArea() + " ]";
        }
    }
}
