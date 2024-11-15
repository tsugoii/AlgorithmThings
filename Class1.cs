using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _451_1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            double result1 = 1;
            double result2 = 0;
            Console.WriteLine("I work");
            for (double n = 0; result1 > result2; n++)
            {
                result1 = (10 * (Math.Pow(n, 2.0) + 6));
                result2 = ((21 * n) + 7);
                Console.WriteLine("Algorithm One: " + result1);
                Console.WriteLine("Algorithm Two: " + result2);
                Console.ReadKey();
            }
            Console.WriteLine("I'm Done");
            Console.ReadKey();
        }
    }
}
