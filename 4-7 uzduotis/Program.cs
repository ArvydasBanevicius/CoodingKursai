using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsijus = Convert.ToDouble( Console.ReadLine());
            double skaicius2 = (celsijus * 1.8) + 32;

            Console.WriteLine("celsijus={0}, faringatai = {1}", celsijus, skaicius2);
            Console.ReadLine();
        }
    }
}
