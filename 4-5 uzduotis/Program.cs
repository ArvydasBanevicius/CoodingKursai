using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = Convert.ToDouble(Console.ReadLine());
            double skaicius2;
            for (int i=0; i<10; i++)
            {
                skaicius2 = skaicius * i;
                Console.WriteLine("{0}+{1}={2}", skaicius, i, skaicius2);
            }

            Console.ReadLine();
        }
    }
}
