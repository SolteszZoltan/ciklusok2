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
            else
            {
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

            Console.WriteLine("-------------------------------------------3.feladat----------------------------------------");

            List<int> parosak = new List<int>();
            List<int> paratlanok = new List<int>();

            Console.WriteLine("Adj meg 10 számot:");

            for (int i = 0; i < 10; i++)
            {
                int szam11 = int.Parse(Console.ReadLine());

                if (szam11 % 2 == 0)
                    parosak.Add(szam11);
                else
                    paratlanok.Add(szam11);
            }
            for (int i = 0; i < parosak.Count; i++)
            {

            }
            Console.WriteLine("Párosak" + " " + parosak.Count + "db");
            for (int i = 0; i < paratlanok.Count; i++)
            {

            }
            Console.WriteLine("Páratlanok" + " " + paratlanok.Count + "db");

            Console.WriteLine("--------------------------------4.feladat------------------------");
            Console.WriteLine("Adj meg egy szót (a vége szó leállitja): ");
            string szavak = Console.ReadLine();
            int szamolo = 0;
            if (szavak.Length > 5)
            {
                szamolo++;
            }
            while (szavak != "vége")
            {
                Console.WriteLine("Adj meg egy másikat: ");
                szavak = Console.ReadLine();

            if (szavak.Length > 5)
                {
                    szamolo++;
                }
            }
            Console.WriteLine($"Ennyi 5 betűnél hosszabb szó van: {szamolo}");
        }
    }
}

