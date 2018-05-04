using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4;
            var b = 5;
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            Console.WriteLine("{0}/{1}={2}", a, b, (double)a / b);
            Console.WriteLine("{0}%{1}={2}", a, b, (double)a % b);
            Console.ReadLine();
        }
    }
}
