using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Preke
    {
        public string Pavadinimas;
        public int Kiekis;
        public double Kainas;
        public DateTime PagaminimoData;

        public Preke(string pavadinimas, int kiekis, double kaina, DateTime pagaminimodata)
        {
            Pavadinimas = pavadinimas;
            Kiekis = kiekis;
            Kainas = kaina;
            PagaminimoData = pagaminimodata;
        }
        public Preke(string eilute)
        {
            string[] Parametrai = eilute.Split(';');
            Pavadinimas = Parametrai[0];
            Kiekis = Convert.ToInt32( Parametrai[1] );
            try
            {
                Kainas = Convert.ToDouble(Parametrai[2]);
            }
            catch (Exception e) 
            {
            }
            try
            {
                PagaminimoData = Convert.ToDateTime(Parametrai[3]);
            }
            catch (Exception)
            {
            }
        }
}
}
