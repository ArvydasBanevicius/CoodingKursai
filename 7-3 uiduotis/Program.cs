using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3_uiduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var klausimas = 't';
            int Rezultatas;
            int sk1;
            int sk2;
            while (klausimas == 't')
            {
                sk1 = Convert.ToInt32( Console.ReadLine() );
                sk2 = Convert.ToInt32(Console.ReadLine());
                Rezultatas = sk1 + sk2;
                Console.WriteLine("{0}+{1}={2}", sk1, sk2, Rezultatas);
                Rezultatas = sk1 - sk2;
                Console.WriteLine("{0}-{1}={2}", sk1, sk2, Rezultatas);
                Rezultatas = sk1 * sk2;
                Console.WriteLine("{0}*{1}={2}", sk1, sk2, Rezultatas);
                Rezultatas = sk1 / sk2;
                Console.WriteLine("{0}/{1}={2}", sk1, sk2, Rezultatas);
                Console.WriteLine("Ar dar norite ivesti skaicius");
              klausimas = (char)Console.Read();
            }
            Console.ReadLine();
        }
    }
}
