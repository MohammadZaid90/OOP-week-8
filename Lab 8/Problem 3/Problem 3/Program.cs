using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {

       
            Console.WriteLine("Cats");
            Console.Write("1) Enter Cat Name : ");
            string name = Console.ReadLine();
            Cat C1 = new Cat(name);
            Console.Write("2) Enter Cat Name : ");
            string name1 = Console.ReadLine();
            Cat C2 = new Cat(name1);
 
            Console.WriteLine("Dogs");
            Console.Write("1) Enter Dog Name : ");
            string nam = Console.ReadLine();
            Dog D1 = new Dog(nam);
            Console.Write("2) Enter Dog Name : ");
            string nam1 = Console.ReadLine();
            Dog D2 = new Dog(nam1);
            Console.Clear();
      
            Console.WriteLine(C1.Greets());
            Console.WriteLine(C1.Greets());

            Console.WriteLine(D1.Greets());
            Console.WriteLine(D1.Greets());

            Console.WriteLine(C1.toString());
            Console.WriteLine(C2.toString());

            Console.WriteLine(D1.toString());
            Console.WriteLine(D2.toString());
            Console.ReadKey();
        }
    }
}
