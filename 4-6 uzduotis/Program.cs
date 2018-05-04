using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = Convert.ToDouble(Console.ReadLine());
            var skaicius1 = Convert.ToDouble(Console.ReadLine());
            double skaicius2 = (skaicius + skaicius1)/2;

            Console.WriteLine("Skaicius={0}, Skaicius{1}, ju vidurkis = {2}", skaicius, skaicius1, skaicius2);
            Console.ReadLine();
        }
    }
}
