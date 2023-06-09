using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.BL;

namespace Task_4.UI
{
    class CircleUI
    {
        public static Circle TakeInputForCircle()
        {
            Console.Write("Enter Radius : ");
            double rad = float.Parse(Console.ReadLine());
            Circle CircleObj = new Circle("Circle", rad);
            return CircleObj;
        }
    }
}
