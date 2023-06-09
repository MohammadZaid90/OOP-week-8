using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.BL;
using Task_4.DL;

namespace Task_4.UI
{
    class PrintShapesUI
    {
        public static void PrintShapes()
        {
            int x = 1;
            foreach (Shape shape in ShapeDL.ShapesList)
            {
                Console.WriteLine(x + "." + shape.toString());
                x++;
            }
        }
    }
}
