using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Cylinder:Circle
    {
        private double height = 1.0;
        public Cylinder()
        {

        }
        public Cylinder(double radius):base(radius)
        {

        }

        public Cylinder(double radius,double height):base(radius)
        {
            this.height = height;
        }

        public Cylinder(double radius, double height,string color) : base(radius,color)
        { 
        }
        public double getHeight()
        {
            return this.height;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public double getVolume()
        {
            double Volume = (4 / 3 * (3.14 * base.getRadius() * base.getRadius() * height));
            return Volume;
        }

    }
}
