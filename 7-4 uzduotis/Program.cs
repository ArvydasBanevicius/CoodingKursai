using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string Tekstas = "";
            string IvestasTekstas = "";
            while (IvestasTekstas != "exit")
            {
                Tekstas = Tekstas + IvestasTekstas;
                Console.WriteLine(Tekstas);
                IvestasTekstas = Console.ReadLine();
            }
            Tekstas = Tekstas + IvestasTekstas;
            Console.WriteLine(Tekstas);
            Console.ReadLine();
        }
    }
}
