using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._17
{
    class Program
    {
        static int[] GeneraltSzamok = new int[100];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Alap prog tételek
            //összegzés tétel
            //átlagolás
            //maximum minimum kiválasztás
            //megszámlálás
            //eldöntés
            //keresési tétel
            //kiválasztás tétel
            //rendezési tétel

            Feladat1Feltoltes();
            Feladat2Kiiratas();
            Feladat3OsszegzesTetel();
            Feladat4Atlagolas();
            Feladat5MinMacTetel();
            Feladat6Eldontes();
            Feladat7LeszamolasTetel();
            Feladat8KivalasztasTetel();
            Feladat9KeresesiTetel();
            Feladat10RendezesTetel();

            Console.ReadKey();
        }

        private static void Feladat10RendezesTetel()
        {
            Console.WriteLine("Feladat10: (n-1)*(n-1)es rendezés tétel");
            int Csere;
            for (int i = 0; i < GeneraltSzamok.Length-1; i++)
            {
                for (int j = 0; j < GeneraltSzamok.Length-1; j++)
                {
                    if(GeneraltSzamok[j]>GeneraltSzamok[ j +1])
                    {
                        Csere = GeneraltSzamok[j];
                        GeneraltSzamok[j] = GeneraltSzamok[j + 1];
                        GeneraltSzamok[j + 1] = Csere;
                    }
                }
            }
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write("\n\t");
                }
                Console.Write("{0-3}, ",GeneraltSzamok[i]);
            }
        }

        private static void Feladat9KeresesiTetel()
        {
            Console.WriteLine("Feladat9: Keresés");
            Console.Write("Kérem adjon meg egy számot hogy mire akar rákeresni: ");
            int KeresettSzam = int.Parse(Console.ReadLine());
            int Szamlalo = 0;
            while (Szamlalo != GeneraltSzamok.Length && KeresettSzam != GeneraltSzamok[Szamlalo])
            {
                Szamlalo++;
            }
            if (Szamlalo == GeneraltSzamok.Length)
            {
                Console.WriteLine("\tNincs eredménye a keresésnek");
            }
            else
            {
                Console.WriteLine("\tVan ilyen elem mégpedig: {0}",Szamlalo+1);
            }
        }

        private static void Feladat8KivalasztasTetel()
        {
            Console.WriteLine("Feladat8: Kiválasztás tétele");
            //a 100 benne van e a tömbben és hol?
            int Keres = 100;
            int i = 0;
            while(GeneraltSzamok[i]!=Keres)
            {
                i++;
            }
            Console.WriteLine("A 100 előfordulási helye: {0}",i);
        }

        private static void Feladat7LeszamolasTetel()
        {
            Console.WriteLine("Feladat7: Leszámolás/megszámlálás tétele");
            int db = 0;
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                if (GeneraltSzamok[i] % 3 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("\tEnnyi 3-mal osztható szám van a tömbben: {0}",db);
        }

        private static void Feladat6Eldontes()
        {
            Console.WriteLine("Feladat6: Eldöntési tétel");
            int db = 0;
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                if (GeneraltSzamok[i] > 60)
                {
                    db++;
                }
            }
            if (db > 0)
            {
                Console.WriteLine("\tVan olyan értéked ami 60-nál nagyobb");
            }
            else
            {
                Console.WriteLine("\tNincs ilyen elem");
            }
        }

        private static void Feladat5MinMacTetel()
        {
            Console.WriteLine("Feladat5: Min Max kiv tétel");
            //Minimum tétel
            int Min = int.MaxValue;
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                if (GeneraltSzamok[i] < Min)
                {
                    Min = GeneraltSzamok[i];
                }
            }
            Console.WriteLine("\tA tömb legkisebb eleme: {0}",Min);
            int Max = int.MinValue;
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                if (Max < GeneraltSzamok[i])
                {
                    Max = GeneraltSzamok[i];
                }
            }
            Console.WriteLine("\tA tömb legnagyobb eleme: {0}",Max);

        }

        private static void Feladat4Atlagolas()
        {
            Console.WriteLine("Feladat4: Átlagolás tétel");
            int Osszeg = 0;
            double Atlag = 0;
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                //Osszeg+=GeneraltSzamok[i];
                Osszeg = Osszeg + GeneraltSzamok[i];

            }
            Atlag = (double)Osszeg / GeneraltSzamok.Length;
            Console.WriteLine("\t A generált számok összege: {0}", Osszeg);
            Console.WriteLine("\t A generált számok átlaga: {0:0.00}",Atlag);
        }

        private static void Feladat3OsszegzesTetel()
        {
            Console.WriteLine("Feladat3: Összegzési tétel");
            int Osszeg = 0;
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                //Osszeg+=GeneraltSzamok[i];
                Osszeg = Osszeg+GeneraltSzamok[i];

            }
            Console.WriteLine("\t A generált számok összege: {0}",Osszeg);
        }

        private static void Feladat2Kiiratas()
        {
            Console.WriteLine("Feladat2: kiiratás");
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                if (i % 6 == 0)
                {
                    Console.Write("\n\t");
                }
                Console.Write("{0}, ",GeneraltSzamok[i]);
            }
        }

        private static void Feladat1Feltoltes()
        {
            Console.WriteLine("Feladat1: feltöltés");
            /*int Szam; //klasszikus feltöltés nem alkamas arra hogy feltételnek megfelelően adjuk a rendszer számát
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                Szam = rnd.Next(50, 150);
                GeneraltSzamok[i] = Szam;
            }*/
            int Szam;
            int Db = 0;
            while(Db!=GeneraltSzamok.Length)
            {
                Szam = rnd.Next(50, 150);
                if (Szam % 5 == 0)//olyan számokkal töltöm fel a tömböt amik 5el oszthatók
                {
                    
                    GeneraltSzamok[Db] = Szam;
                    Db++;//biztositja h a feltételnek eleget tevő számok kerüljenek csak be
                }
                
            }

        }
    }
}
