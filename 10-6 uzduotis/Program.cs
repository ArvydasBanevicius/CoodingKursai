using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        { 
            var Sarasas = new Dictionary<string, Int32>();
            Sarasas = Ivedimas();

            Console.ReadLine();
        }

        static Dictionary<string,Int32> Ivedimas()
        {
            var sar = new Dictionary<string, Int32>();
            Console.Write("Iveskite saraso ilgi:");
            var Ilgis = Convert.ToInt32( Console.Read() );
            var i = 0;
            do
            {
                try
                {
                    var Pavadinimas = Console.ReadLine();
                    var Reiksme = Convert.ToInt32( Console.ReadLine() );
                    sar.Add(Pavadinimas, Reiksme);
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Klaidingai ivesti duomenys");
                    //throw;
                }
            }
            while (i < Ilgis);
            return sar;
        }
    }
}
