using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.BL;

namespace Task_4.UI
{
    class SquareUI
    {
        public static Square TakeInputForSquare()
        {
            Console.Write("Enter Side : ");
            double side = float.Parse(Console.ReadLine());
            Square SquareObj = new Square("Square", side);
            return SquareObj;
        }
    }
}
