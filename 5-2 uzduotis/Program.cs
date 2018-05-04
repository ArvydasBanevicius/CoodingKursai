using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var amzius = Convert.ToInt16(Console.ReadLine());
            if (amzius >= 18)
            {
                Console.WriteLine("Jus galite balsuoti");
            }
            Console.ReadLine();
        }
    }
}
