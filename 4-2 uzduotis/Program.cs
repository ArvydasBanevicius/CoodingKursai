using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = Convert.ToDouble( Console.ReadLine() );
            var skaicius1 = Convert.ToDouble( Console.ReadLine() );
            var skaicius2 = skaicius + skaicius1;

            Console.WriteLine("{0}+{1}={2}", skaicius, skaicius1, skaicius2);
            skaicius2 = skaicius * skaicius1;
            Console.WriteLine("{0} * {1}={2}", skaicius, skaicius1, skaicius2);
            skaicius2 = skaicius / skaicius1;
            Console.WriteLine("{0} / {1}={2}", skaicius, skaicius1, skaicius2);
            skaicius2 = skaicius % skaicius1;
            Console.WriteLine("{0} % {1}={2}", skaicius, skaicius1, skaicius2);
            
            Console.ReadLine();
        }
    }
}
