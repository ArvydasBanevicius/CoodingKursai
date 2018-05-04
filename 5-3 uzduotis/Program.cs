using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = Convert.ToInt16(Console.ReadLine());
            if (skaicius < 0)
            {
                Console.WriteLine("Rekiam ant kazko");
            }
            if (skaicius > 0)
            {
                Console.WriteLine("Sveikinam kazka");
            }
            if (skaicius % 2 == 0)
            {
                Console.WriteLine("Sakicius lyginis");
            }
            if (skaicius % 4 == 0)
            {
                Console.WriteLine("Dalinasi is 4");
            }
            if (skaicius > 10)
            {
                Console.WriteLine("Sakicius didesnis uz 10");
            }
            Console.ReadLine();
        }
    }
}
