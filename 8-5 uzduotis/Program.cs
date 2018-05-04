using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var RandomObjektas = new Random();

            Console.Write("Kiek ipyliau kuro = ");
            int KuroKiekisLitrais = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite kelioniu skaiciu = ");
            int KelioniuSkaicius = Convert.ToInt32(Console.ReadLine());

            var Keliones = new int[KelioniuSkaicius];
            int Bendraskelias=0;
            for (int i = 0; i < Keliones.Length; i++)
            {
                Keliones[i] = RandomObjektas.Next(300);
                Bendraskelias += Keliones[i];
                Console.WriteLine("Kelione {0} km = {1}", i+1, Keliones[i] );
            }
            Console.WriteLine("Nuvaziavom is viso = {0}", Bendraskelias);
            var min = Keliones[0];
            var max = Keliones[0];
            foreach (var sk in Keliones)
            {
                if (min > sk)
                {
                    min = sk;
                }
                if (max < sk)
                {
                    max = sk;
                }
            }

            double SimtuiKiluSunaudota = ((double)KuroKiekisLitrais / (double)Bendraskelias) * 100.0;
            Console.WriteLine("Trumpiausia kelione = {0}, ilgiausia kelione = {1}", min, max);
            Console.WriteLine("Sunaudota simtui kilu degalu = {0}", SimtuiKiluSunaudota);
            Console.ReadLine();
        }
    }
}
