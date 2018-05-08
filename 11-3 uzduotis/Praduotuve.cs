using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//susikurti klasę prekės duomenims saugoti, turėti šiuos duomenis:
//- pavadinimas
//- kaina
//- savikaina
//- kiekis
//metodai:
//- rasti prekės pelną(kaina - savikaina)
//- ar prekės likutis yra mažas(taip jei mažiau nei 5 prekės)

//susikute klasę parduotuvės duomenims saugoti, joje yra šie duomenys:
//- pavadinimas
//- adresas
//- plotas
//- prekių sąrašas(naudoti prekė klasės objektų sąrašą)
//metodai:
//- rasti kurių prekių yra daugiausiai
//- išvesti visas prekes kurių likutis yra mažas
//- rasti kurios prekės kaina yra didžiausia
//- rasti kurios prekės savikaina yra mažiausia
//- rasti kurio prekės pelnas yra didžiausias
//- apskaičiuoti kiek parduotuvė gaus pelno pardavus visas prekes

namespace _11_3_uzduotis
{
    class Praduotuve
    {
        public string Pavadinimas = "IKI";
        public string Adresas = "Kuršių 34";
        public double Plotas = 250.0;
        List<Preke> Prekes = new List<Preke>();

        public Praduotuve()
        {
            Prekes.Add(new Preke("Kelne", 15, 5, 100));
            Prekes.Add(new Preke("Marskiniai", 10, 8, 200));
            Prekes.Add(new Preke("Duona", 1.4, 0.5, 50));
            Prekes.Add(new Preke("Pienas", 0.85, 0.2, 150));
        }

        public Preke KokiuPrekiuYraDaugiausia()
        {
            Preke surastaPreke = Prekes.First();
            int Kiekis = 0;
            foreach (var preke in Prekes)
            {
                if (Kiekis < preke.Kiekis)
                {
                    surastaPreke = preke;
                }
            }
            return surastaPreke;
        }

        public int ArYraPerMazaiPrekiu()
        {
            int maziausias = 0;
            foreach(var preke in Prekes)
            {
                maziausias += preke.ArPrekiuNePerMazai();
            }
            return maziausias;
        }

        public Preke DidziausiaPrekesKaina()
        {
            Preke PrekeSuDidziausiaKaina = Prekes.First();
            foreach (var preke in Prekes)
            {
                if (PrekeSuDidziausiaKaina.Kaina < preke.Kaina)
                    PrekeSuDidziausiaKaina = preke;
            }
            return PrekeSuDidziausiaKaina;
        }

        public Preke DidziausiasPelnasNuoPrekes()
        {
            Preke diziausiasPelnas = Prekes.First();
            double Pelnas = 0;
            foreach (var preke in Prekes)
            {
                if (Pelnas < preke.PelnasNuoPrekes())
                    diziausiasPelnas = preke;
            }
            return diziausiasPelnas;
        }

        public double KiekBusPelnoIsipardavus()
        {
            double Pelnas = 0;
            foreach (var preke in Prekes)
            {
              Pelnas += preke.PelnasNuoPrekes();
            }
            return Pelnas;
        }


        public void Isvedimas()
        {
            foreach (var preke in Prekes)
            {
                preke.Isvedimas();
            }

            Console.Write("Parduotuve: ", Pavadinimas );
            Console.Write("adresu: ", Adresas );
            Console.Write("Parduotuves plotas: ", Plotas );

            Console.Write("Kokiu prekiu yra daugiausiai: ");
            KokiuPrekiuYraDaugiausia().Isvedimas();
            Console.Write( "Kiek yra prekiu, kuriu maziau negu 5: {0}", ArYraPerMazaiPrekiu() );
            Console.Write("Kurios prekes didziuasia kaina: ");
            DidziausiaPrekesKaina().Isvedimas();
            Console.Write("Didziausias pelnas nuo prekes: ");
            DidziausiasPelnasNuoPrekes().Isvedimas();
            Console.Write("Viska pardavus parduotuve tures pelno: {0}", KiekBusPelnoIsipardavus());
        }
    }
}
