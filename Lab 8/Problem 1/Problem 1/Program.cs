using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder C1 = new Cylinder();
            Console.Write("Enter Radius : ");
            double rad = double.Parse(Console.ReadLine());
            C1.setRadius(rad);
            Console.Write("Enter Height : ");
            double hei = double.Parse(Console.ReadLine());
            C1.setHeight(hei);
            Console.Write("Enter Colour : ");
            string col = Console.ReadLine();
            C1.setColor(col);

            Console.WriteLine(C1.toString());
            Console.ReadKey();
        }
    }
}
