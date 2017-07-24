using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Akhir_1__Lingkaran
{
    class Program
    {
        static void Main(string[] args)
        {
            const double phi = 3.14;
            double pi = 22 / 7;
            double r;

            Console.Write("Input the value of R :");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("======= Circle =======");
            if (r == 7)
            {
                Console.WriteLine(" Wide = phi x r^2 :{0} ", (pi * (r * r)));
                Console.WriteLine(" \nCircumference = 2 x phi x r :{0} ", (2 * pi * r));
            }
            else
            {
                Console.WriteLine(" \nWide = phi x r^2 : {0} ", (phi * (r * r)));
                Console.WriteLine(" \nCircumference = 2 x phi x r : {0}", (2 * phi * r));
            }
            Console.ReadLine();
        }
    }
}
