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

            Console.WriteLine("------------5.feladat--------");
            List<int> osztalyzatok = new List<int>();
            Console.WriteLine("Add meg a jegyed 1-5 (-1 = kilépés): ");
            int osztalyzat = int.Parse(Console.ReadLine());
            if (osztalyzat == 0)
            {
                Console.WriteLine("A 0 nem értelmezhető osztályzat");
            }
            osztalyzatok.Add(osztalyzat);
            while (osztalyzat != -1)
            {
                Console.WriteLine("Add meg a következő jegyet: ");
                osztalyzat = int.Parse(Console.ReadLine());
                osztalyzatok.Add(osztalyzat);
                if (osztalyzat == 0)
                {
                    Console.WriteLine("A 0 nem értelmezhető osztályzat");
                }
                osztalyzatok.Add(osztalyzat);
            }
            int osztazatszamolo = 0;
            for (int x = 0; x < osztalyzatok.Count; x++)
            {
                osztazatszamolo += osztalyzatok[x];
            }
            Console.WriteLine($"Az összeg: {osztazatszamolo}");
            float szml = osztazatszamolo % osztalyzatok.Count;
            Console.WriteLine(szml);
            {

            }
            for (int g = 0; g < osztalyzatok.Count; g++) ;

            Console.WriteLine("-----6.feladat-----");
            Console.WriteLine("Adj meg egy számot 1 és 10 között:");
            int szam55 = int.Parse(Console.ReadLine());

            for (int m = 1; m <= 10; m++)
            {
                int eredmeny = szam55 * m;

                if (eredmeny % 3 == 0)
                {
                    Console.WriteLine(szam55 + " * " + m + " = " + eredmeny);
                }
            }
            Console.WriteLine("----7.feladat-----");

            Console.WriteLine("Adj meg 10 számot:");

            for (int i = 0; i < 10; i++)
            {
                int szam66 = int.Parse(Console.ReadLine());

                if (szam66 > 0)
                    Console.WriteLine(szam66 + " pozitív");
                else if (szam66 < 0)
                    Console.WriteLine(szam66 + " negatív");
                else
                    Console.WriteLine(szam66 + " nulla");

                if (szam66 % 2 == 0)
                    Console.WriteLine(szam66 + " páros");
                else
                    Console.WriteLine(szam66 + " páratlan");

                if (szam66 % 3 == 0)
                    Console.WriteLine(szam66 + " osztható 3-mal");
                else
                    Console.WriteLine(szam66 + " nem osztható 3-mal");

                Console.WriteLine();

            }
        }
    }
}

