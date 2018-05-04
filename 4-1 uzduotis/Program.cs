using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = Convert.ToChar(Console.Read());
            Console.ReadLine();
            Console.WriteLine("{0}{1}{2}", skaicius,skaicius,skaicius);
            Console.WriteLine("{0} {2}", skaicius, skaicius, skaicius);
            Console.WriteLine("{0}{1}{2}", skaicius, skaicius, skaicius);

            Console.ReadLine();
        }
    }
}
