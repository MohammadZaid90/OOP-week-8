using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.BL;
using Task_4.DL;
using Task_4.UI;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle printRect = RectangleUI.TakeInputForRectangle();
            ShapeDL.AddShapeIntoList(printRect);
            Circle printCircle = CircleUI.TakeInputForCircle();
            ShapeDL.AddShapeIntoList(printCircle);
            Square printSquare = SquareUI.TakeInputForSquare();
            ShapeDL.AddShapeIntoList(printSquare);
            Rectangle printRect1 = RectangleUI.TakeInputForRectangle();
            ShapeDL.AddShapeIntoList(printRect1);
            Circle printCircle1 = CircleUI.TakeInputForCircle();
            ShapeDL.AddShapeIntoList(printCircle1);
            PrintShapesUI.PrintShapes();
            Console.ReadKey();
        }
    }
}
