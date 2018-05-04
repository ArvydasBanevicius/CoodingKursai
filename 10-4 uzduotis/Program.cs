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
            var amzius = program.VartotojoAmzius();
            program.SitoTipoAmzius(amzius);

            var a = program.IvestiSkaiciu(1);
            var b = program.IvestiSkaiciu(1);

            Console.WriteLine("Gauname rezultata {0}", program.Skaiciujame(a, b));

            Console.ReadLine();
        }

        public int IvestiSkaiciu(int Sk)
        {
            Console.Write("Iveskite {0} skaiciu: ", Sk);
            var ats = Convert.ToInt32(Console.ReadLine());
            return ats;
        }

        public int Skaiciujame(int sk1, int sk2)
        {
            return sk1 + sk2;
        }

        public void Pasisveikinam( string vardas )
        {
            Console.WriteLine("Sveikas, {0}", vardas);
        }

        public void SitoTipoAmzius(int amzius)
        {
            Console.WriteLine("Sito tipo amzius {0}", amzius);
        }

        public string VartotojoVardas()
        {
            Console.Write("Iveskite varda: ");
            var vardas = Console.ReadLine();
            return vardas;
        }

        public int VartotojoAmzius()
        {
            Console.Write("Iveskite vartotojo amziu: ");
            var amzius = Convert.ToInt32( Console.ReadLine() );
            return amzius;
        }
    }
}
