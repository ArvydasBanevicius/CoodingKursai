using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4;
            var b = 5;
            double c;
            Console.WriteLine("{0}*{1}={2}", a, b, a *= 2);
            c = Math.Pow(a, 3);
            Console.WriteLine("{0}.pow{1}={2}", a, 3, a);
            Console.ReadLine();
        }
    }
}
