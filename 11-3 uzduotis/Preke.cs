using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3_uzduotis
{
    class Preke
    {
        public string Pavadinimas;
        public double Kaina;
        public double Savikaina;
        public int Kiekis;

        public Preke(string pavadinimas, double kaina, double savikaina, int kiekis)
        {
            Pavadinimas = pavadinimas;
            Kaina = kaina;
            Savikaina = savikaina;
            Kiekis = kiekis;
        }

        public double PelnasIsPrekes()
        {
            return (Kaina - Savikaina) * Kiekis;
        }

        public int ArPrekiuNePerMazai()
        {
            return Convert.ToInt32(Kiekis < 5);
        }

        public double PelnasNuoPrekes()
        {
            return (Kaina - Savikaina);
        }

        public void Isvedimas()
        {
            Console.WriteLine("Prekes pavadinimas: {0}; kaina: {1}; savikaina: {2}; kiekis: {3}",Pavadinimas,Kaina,Savikaina,Kiekis);
        }
    }
}
