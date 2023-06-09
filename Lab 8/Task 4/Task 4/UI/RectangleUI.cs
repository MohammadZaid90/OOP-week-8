using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.BL;

namespace Task_4.UI
{
    class RectangleUI
    {
        public static Rectangle TakeInputForRectangle()
        {
            Console.Write("Enter Width : ");
            double wid = float.Parse(Console.ReadLine());
            Console.Write("Enter Height : ");
            double hei = float.Parse(Console.ReadLine());
            Rectangle RectObj = new Rectangle("Rectangle", wid, hei);
            return RectObj;
        }
    }
}
