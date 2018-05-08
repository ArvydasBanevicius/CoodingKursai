using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_uzduotis2
{
    class Prieglauda
    {
        public string Pavadinimas;
        public string Adressas;
        //public List<Suo> Sunys = new List<Suo>();
        public List<Suo> Sunys;

        public Prieglauda(string pavadinimas, string adresas)
        {
            Pavadinimas = pavadinimas;
            Adressas = adresas;
            Sunys = new List<Suo>();
        }

        public Prieglauda(string pavadinimas, string adresas,List<Suo> sunys)
        {
            Pavadinimas = pavadinimas;
            Adressas = adresas;
            Sunys = sunys;
        }

        public void CheckIn()
        {
            char raide;
            do
            {
                Console.WriteLine("Dar atvesti suni?");
                raide = Console.ReadKey().KeyChar;
                if (raide == 'y')
                {
                    Console.WriteLine();
                    Sunys.Add( new Suo() );
                }
            }
            while (raide == 'y');
        }


        public Suo VyriausiasSuo()
        {
            var vyriausias = Sunys.First();
            foreach(var suo in Sunys)
            {
                if (vyriausias.Amzius < suo.Amzius)
                {
                    vyriausias = suo;
                }
            }
            return vyriausias;
        }

        public Suo JauniausiasSuo()
        {
            var jauniausias = Sunys.First();
            foreach (var suo in Sunys)
            {
                if (jauniausias.Amzius < suo.Amzius)
                {
                    jauniausias = suo;
                }
            }
            return jauniausias;
        }

        public double SunuAmziausVidurkis()
        {
            double vidurkis = 0;
            foreach (var suo in Sunys)
            {
                    vidurkis += suo.Amzius;
            }
            vidurkis /= Sunys.Count;
            return vidurkis;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Prieglaudos pavadinimas \"{0}\", adresu \"{1}\"", Pavadinimas, Adressas);
            foreach( var suo in Sunys)
            {
                suo.Isvedimas();
            }
            Console.Write("Vyriausias suo: " );
            VyriausiasSuo().Isvedimas();
            Console.Write("Jauniausias suo: ");
            JauniausiasSuo().Isvedimas();
            Console.WriteLine("Sunu amziaus vidurkis: {0}", SunuAmziausVidurkis() );
        }

    }
}
