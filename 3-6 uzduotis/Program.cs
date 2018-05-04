using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var kint = 23;
            Console.WriteLine("{0}*{1}={2}", kint / 10, kint % 10, (kint / 10)*(kint % 10));
            Console.ReadLine();
        }
    }
}
