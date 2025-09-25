using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklusok2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg még egy számot: ");
            int szam2 = int.Parse(Console.ReadLine());
            int szam3 = 0;
            if (szam > szam2)
            {
                szam3 = (szam - szam2) - 1;
                Console.WriteLine($"A két szám között {szam3} szám van");
            }
            else if (szam < szam2)
            {
                szam3 = (szam2 - szam) - 1;
                Console.WriteLine($"A két szám között {szam3} szám van");

            }
            else {
                Console.WriteLine("A két szám egyenlő");
            }


        }
    }
}
