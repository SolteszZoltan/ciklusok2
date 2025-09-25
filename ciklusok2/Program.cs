using System;
using System.Collections.Generic;
using System.Data;
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

            Console.WriteLine("--------------------------------2.feladat-----------------------------------");

            Console.WriteLine("Adj meg egy számot");
            int nulla = int.Parse(Console.ReadLine());
            List<int> szamok = new List<int>();
            while (nulla != 0)
            {
                szamok.Add(nulla);
                Console.WriteLine("Adj meg egy másikat.");
                nulla = int.Parse(Console.ReadLine());
            }
            if (szamok.Count == 0)
            {
                return;
            }
            int legtobb = szamok[0];
            int szamdb = 1;


            for (int i = 0; i < szamok.Count; i++)
            {
                int mostaniSzam = szamok[i];  
                int db = 0;

                for (int j = 0; j < szamok.Count; j++)
                {
                    if (szamok[j] == mostaniSzam)
                    {
                        db++;
                    }
                }

                if (db > szamdb)
                {
                    szamdb = db;
                    legtobb = mostaniSzam;
                }
            }
            Console.WriteLine("A legtöbbször megadott szám: " + legtobb);
        }
    }
}
