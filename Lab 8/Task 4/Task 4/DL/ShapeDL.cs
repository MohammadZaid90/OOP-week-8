using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.BL;

namespace Task_4.DL
{
    class ShapeDL
    {
        public static List<Shape> ShapesList = new List<Shape>();
        public static void AddShapeIntoList(Shape obj)
        {
            ShapesList.Add(obj);
        }
    }
}
