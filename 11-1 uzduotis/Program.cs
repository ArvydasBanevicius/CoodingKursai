using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_uzduotis
{
    class Automobilis
    {
        // public AbcAbc pascal case
        // private _abcAbc camel case

        public int GimimoMetai;
        public string Spalva;
        public string Marke;
        public string VIN;
        public string VatstyvinisNumeris;

        public Automobilis()
        {
            Spalva = "Balta";
            Console.WriteLine();
            Console.WriteLine("hbgbgb");
        }

        public Automobilis(int gimimoMetai = 0, string spalva = "", string marke = "", string vin = "", string valstNumeris = ""):base()
        {
            GimimoMetai = gimimoMetai;
            Marke = marke;
            Spalva = spalva;
            VIN = vin;
            VatstyvinisNumeris = valstNumeris;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Gimes:{0}, marke:{1}, spalva:{2}, valst.numeris:{3}", GimimoMetai,Marke,Spalva,VatstyvinisNumeris);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Automobilis auto = new Automobilis();
            auto.GimimoMetai = 2005;
            auto.Spalva = "Raudona";
            Console.WriteLine(auto.GimimoMetai);
            Console.WriteLine(auto.Spalva);

            var auto2 = new Automobilis()
            {
                GimimoMetai = 2010,
                Marke = "VW",
                Spalva = "Juoda",
                VatstyvinisNumeris = "FUM182"
            };

            Console.WriteLine(auto2.GimimoMetai);
            Console.WriteLine(auto2.Marke);
            Console.WriteLine(auto2.Spalva);
            Console.WriteLine(auto2.VatstyvinisNumeris);

            var auto3 = new Automobilis(2010,"Geltona","Volga");
            auto3.Isvedimas();

            Console.ReadLine();
        }
    }
}
