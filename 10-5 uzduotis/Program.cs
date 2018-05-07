using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5_uzduotis
{
    class Program
    {

        static void Main(string[] args)
        {
            Program programa = new Program();

            var balai2017 = new Dictionary<string, int>();
            var balai2016 = new Dictionary<string, int>();

            balai2017 = programa.Ivedimas(2017);
            balai2016 = programa.Ivedimas(2016);

            programa.Isvedimas(2016, balai2016);
            programa.Isvedimas(2017, balai2017);

            programa.MaziasiasBalas(2016, balai2016);
            programa.MaziasiasBalas(2017, balai2017);

            var vid2016 = programa.Vidurkis(2016, balai2016);
            var vid2017 = programa.Vidurkis(2017, balai2017);

            programa.AukstesniUzVidurkiElementuSk(2016, vid2016, balai2016);
            programa.AukstesniUzVidurkiElementuSk(2017, vid2017, balai2017);

            Console.WriteLine("{0} metais metais balu vidurkis yra didesnis", ((vid2016 > vid2017) ? (2016) : (2017)));

            var min = programa.KuriameSaraseMaziausiasElementas(2016, balai2016.ElementAt(0).Value, balai2016);
            programa.KuriameSaraseMaziausiasElementas(201, min, balai2017);

            Console.ReadLine();
        }

        public int KuriameSaraseMaziausiasElementas(int metai, int min, Dictionary<string, int> balai)
        {
            int yra = 0;
            foreach (var balas in balai)
            {
                if (min > balas.Value) yra += 1;
            }

            if (yra > 0)
                Console.WriteLine("Dalyvaujanciu saliu Eurovizijoje {0} maziausias balu skaicius :", metai);
            return min;
        }

        public void AukstesniUzVidurkiElementuSk(int metai, double vid, Dictionary<string, int> balai)
        {
            Console.Write("Dalyvaujanciu saliu Eurovizijoje {0} metais aukstesniu uz vidurki balu skaicius :", metai);
            var suma = 0;
            foreach (var balas in balai)
            {
                if (vid <= balas.Value) suma += 1;
            }

            Console.WriteLine(suma);
        }

        public double Vidurkis(int metai, Dictionary<string, int> balai)
        {
            Console.Write("Dalyvaujanciu saliu Eurovizijoje {0} metais balu vidurkis :", metai);
            double suma = 0;
            for (int i = 0; i < balai.Count; i++)
            {
                suma += balai.ElementAt(i).Value;
            }

            suma /= (double)balai.Count;
            Console.WriteLine(suma);
            return suma;
        }

        public void MaziasiasBalas(int metai, Dictionary<string, int> balai)
        {
            Console.WriteLine("Dalyvaujanciu saliu Eurovizijoje {0} metais balu suma :", metai);
            var min = balai.ElementAt(0).Value;
            var index = 0;
            for (int i = 0; i<balai.Count; i++)
            {
                if (min > balai.ElementAt(i).Value)
                {
                    index = i;
                    min = balai.ElementAt(i).Value;
                }
            }
            Console.WriteLine("Maziausias balas yra skirtas : {0}", balai.ElementAt(index).Key);
        }

        public int Suma(int metai, Dictionary<string, int> balai)
        {
            Console.WriteLine("Dalyvaujanciu saliu Eurovizijoje {0} metais balu suma :", metai);
            var suma = 0;
            foreach (var balas in balai)
            {
                suma += balas.Value;
            }
            Console.WriteLine(suma);
            return suma;
        }

        public void Isvedimas(int metai, Dictionary<string, int> balai )
        {
            Console.WriteLine("Dalyvaujanciu saliu Eurovizijoje {0} metais :", metai);
            foreach ( var balas in balai)
            {
                Console.WriteLine(balas.Key + ":" + balas.Value);
            }
        }

        public Dictionary<string, int> Ivedimas( int KuriasMetais )
        {
            var balai = new Dictionary<string, int>();
            Console.Write("Kiek bus dalyvaujanciu saliu Eurovizijoje {0} metais? :", KuriasMetais);
            var SaliuSkaicius = Convert.ToInt32( Console.ReadLine() );
            var i = 0;
            do
            {
                Console.Write("Iveskite salies pavadinima :");
                var SaliesPavadinimas = Console.ReadLine();

                Console.Write("Iveskite balu skaiciu :");
                var SaliesBalai = Convert.ToInt32(Console.ReadLine());

                balai.Add(SaliesPavadinimas, SaliesBalai);
            }
            while (++i < SaliuSkaicius);
            return balai;
        }
    }
}
