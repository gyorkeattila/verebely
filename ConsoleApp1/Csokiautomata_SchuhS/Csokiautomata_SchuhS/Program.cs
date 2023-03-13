using System.Text;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static List<Csoki> Csoki_List = new List<Csoki>();
        static void Main(string[] args)
        {
            Feladat1Beolvasas(); Console.WriteLine("\n----------------\n");
            Feladat3Max(); Console.WriteLine("\n----------------\n");
            Feladat4150Ft(); Console.WriteLine("\n----------------\n");
            Felada5(); Console.WriteLine("\n----------------\n");
            Feladat6(); Console.WriteLine("\n----------------\n");
            Feladat7(); Console.WriteLine("\n----------------\n");
        }

        private static void Feladat7()
        {
            Console.WriteLine("Feladat 7: K betűs csoki");
            int db = 0;
            foreach (var cs in Csoki_List)
            {
                if(cs.CsokiNeve.ToLower().Contains("k"))
                { db++; }
            }
            Console.WriteLine($"Ennyi K besüt csoki van: {db}");
        }

        private static void Feladat6()
        {
            Console.WriteLine("Feladat 6: Keresés");
            Console.Write("Kérem adjon egy kódot: ");
            string KeresKod=Console.ReadLine();
            int Szamlalo = 0;
            while(Szamlalo<Csoki_List.Count 
                && KeresKod!=Csoki_List[Szamlalo].CsokiKod)
            { Szamlalo++; }
            if(Szamlalo==Csoki_List.Count)
            { Console.WriteLine("Nincs ilyen csoki"); }
            else
            { Console.WriteLine($"Csoki neve: {Csoki_List[Szamlalo].CsokiNeve} :" +
                $"{Csoki_List[Szamlalo].CsokiAr}"); }    

        }

        private static void Felada5()
        {
            Console.WriteLine("Feladat 5: Minden csokiból egyet");
            int OsszKTG = 0;
            foreach (var cs in Csoki_List)
            {
                OsszKTG += cs.CsokiAr;
            }
            Console.WriteLine($"Minden csokiból egyet véve: {OsszKTG} Ft");
        }

        private static void Feladat4150Ft()
        {
            Console.WriteLine("Feladat 4: 150-ért csokit");
            foreach (var cs in Csoki_List)
            {
                if(cs.CsokiAr<=150)
                { Console.WriteLine($"{cs.CsokiNeve} : {cs.CsokiAr}"); }
            }
        }

        private static void Feladat3Max()
        {
            Console.WriteLine("Feladat 3: Legdrágább csoki");
            int MaxAr = int.MinValue;
            string MaxNev = "cica";
            foreach (var cs in Csoki_List)
            {
                if(MaxAr<cs.CsokiAr)
                { 
                    MaxAr = cs.CsokiAr;
                    MaxNev = cs.CsokiNeve;
                }
            }
            Console.WriteLine($"Legdrágább csoki ára: {MaxAr} Ft" +
                $"\nLegdrágább csoki neve: {MaxNev}");
           
        }

        private static void Feladat1Beolvasas()
        {
            Console.WriteLine("Feladat 1: Beolvasás");
            int db = 0;
            var sr= new StreamReader(@"csoki.txt", Encoding.UTF8);
            while(!sr.EndOfStream)
            {
                Csoki_List.Add(new Csoki(sr.ReadLine()));
                db++;
            }
            sr.Close();
            if (db > 0) { Console.WriteLine($"Sikeres beolvasás. ");
                Console.WriteLine($"Feladat 2: \n" +
                    $"Beolvasott sorok száma: {db}");
            }
            else
            { Console.WriteLine("Sikertelen beolvasás"); }
        }
    }
}