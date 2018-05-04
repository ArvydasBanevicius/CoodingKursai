using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk = Convert.ToInt16(Console.ReadLine());
            if (sk >= 18)
            {
                Console.WriteLine("Biski daugiau uz 18");
            }
            else if (sk >= 16)
            {
                Console.WriteLine("Biski daugiau uz 16 arba 17");
            }
            else if (sk >= 10)
            {
                Console.WriteLine("Biski daugiau uz 10, bet nevyresnis uz16");
            }
            Console.WriteLine("Programos pabaiga");
            Console.ReadLine();
        }
    }
}
