using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int sk = 1;
            while (sk % 9 != 0)
            {
                Console.WriteLine("Iveskite skaiciu");
                sk = Convert.ToInt32( Console.ReadLine() );
            }
            Console.WriteLine("Sitas skaicius {0} dalinas is 9 ", sk);
            Console.ReadLine();
        }
    }
}
