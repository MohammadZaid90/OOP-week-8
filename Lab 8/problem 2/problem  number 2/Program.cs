using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem__number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Zaid", "Lahore", "BSCS", 2023, 50000);
            Student s2 = new Student("Tazeem", "Kasur", "BSCS", 2022, 60000);

            Staff t1 = new Staff("Zaid", "Lahore", "LEHS", 23.00);
            Staff t2 = new Staff("Zaid", "Lahore", "LPS", 900.34);

            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());
            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());
            Console.ReadKey();
        }
    }
}
