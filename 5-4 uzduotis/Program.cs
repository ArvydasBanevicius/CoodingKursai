using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk1 = Convert.ToInt16(Console.ReadLine());
            var sk2 = Convert.ToInt16(Console.ReadLine());
            var sk3 = Convert.ToInt16(Console.ReadLine());
            var sk4 = Convert.ToInt16(Console.ReadLine());
            var sk5 = Convert.ToInt16(Console.ReadLine());
            double sk = (sk1+ sk2+ sk3+ sk4+ sk5)/5;
            if (sk >= 5)
            {
                Console.WriteLine("Biski daugiau 5");
            }
            Console.ReadLine();
        }
    }
}
