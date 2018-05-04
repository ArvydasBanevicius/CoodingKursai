using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int Kint = 0;
            int suma = 0;
            for (int sk=1; sk<10; sk++)
            {
                Kint = 0;
                if ((sk & 1) > 0)
                {
                    int d = 3;
                    while (d*d <= sk)
                    {
                        if (sk % d == 0) goto namo;
                        d += 2;
                    }
                    suma += sk;
                namo:
                }
                //if (Kint == 1)
                //{
                //    //Console.WriteLine("sumuojamas skaicius {0}+={1}", suma, sk);
                //}
            }
            Console.WriteLine("Skaicius dalinasi is {0}", suma);
            Console.ReadLine();
        }
    }
}
