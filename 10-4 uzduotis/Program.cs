using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4_uzduotis
{
    class Program
    {
        public Random RandObj;

        public Program() // Constructor
        {
            RandObj = new Random();
        }

        ~Program() // destructor
        {
            Console.WriteLine("Paskutinsi pasisparymas");
        }

        static void Main(string[] args)
        {
            var program = new Program();
            try
            {
                Console.WriteLine("Ivesti skaiciu sarasa");
                var gauta = program.SkaiciusSarasas();
                foreach (var sk in gauta)
                {
                    Console.WriteLine("Gauname rezultata {0}", sk);
                }

                Console.WriteLine("Sarasaso MAX dydis {0}", program.SarasasDidziuaiasElementas(gauta));
                Console.WriteLine("Sarasaso suma {0}", program.SarasasSuma(gauta));
                Console.WriteLine("Sarasaso vidurkis {0}", program.SarasasVidurkis(gauta));

                var vartotojoVardas = program.VartotojoVardas();
                program.Pasisveikinam(vartotojoVardas);
                var amzius = program.VartotojoAmzius();
                program.SitoTipoAmzius(amzius);

                var a = program.IvestiSkaiciu(1);
                var b = program.IvestiSkaiciu(1);

                Console.WriteLine("Gauname rezultata {0}", program.Skaiciujame(a, b));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
            Console.ReadLine();
        }

        public List<int> SkaiciusSarasas()
        {
            List<int> sarasa = new List<int>();
            for (int i = 0; i < 30; i++)
            { 
                sarasa.Add(RandObj.Next(100));
            }
            return sarasa;
        }

        public int SarasasDidziuaiasElementas(List<int> Sarasas )
        {
            return Sarasas.Max();
        }

        public int SarasasSuma(List<int> Sarasas)
        {
            return Sarasas.Sum();
        }

        public double SarasasVidurkis(List<int> Sarasas)
        {
            return Sarasas.Average();
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
