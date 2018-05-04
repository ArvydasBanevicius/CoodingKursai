using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk1 = -5;// Convert.ToInt16(Console.ReadLine());
            while (sk1 <= 0)
            {
                Console.Write(sk1 + " ");
                sk1++;
            }
            Console.ReadLine();
        }
    }
}
