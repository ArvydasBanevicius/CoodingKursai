using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var vartotojoVardas = program.VartotojoVardas();
            program.Pasisveikinam(vartotojoVardas);

            Console.ReadLine();
        }

        public void Pasisveikinam( string vardas )
        {
            Console.Write("Sveikas, {0}", vardas);
        }

        public string VartotojoVardas()
        {
            Console.Write("Iveskite varda: ");
            var vardas = Console.ReadLine();
            return vardas;
        }
    }
}
