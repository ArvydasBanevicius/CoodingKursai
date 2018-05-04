using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pasirinkimas;
            do
            {
                Console.WriteLine("1- laptopas; 2 - stacionarus");
                Pasirinkimas = Convert.ToInt32(Console.ReadLine());
                if (Pasirinkimas < 1 || Pasirinkimas > 2)
                {
                    Console.WriteLine("Blogas pasirinkimas");
                }
            }
            while (Pasirinkimas < 1 || Pasirinkimas > 2);
            Console.WriteLine("Geras pasirinkimas {0}", (Pasirinkimas == 1) ? "laptopas" : "stacionarus");
            Console.ReadLine();
        }
    }
}
