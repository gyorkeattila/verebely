using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
       
        
        static void Main(string[] args)
        {
            List <szalloda> szallodalist= new List <szalloda> ();


            FileStream fs = new FileStream("vendegek.txt", FileMode.Open);
            StreamReader sr= new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                szalloda vendeg= new szalloda(sr.ReadLine());
                szallodalist.Add (vendeg);

            }
            sr.Close();
            fs.Close();

            for (int i = 0; i < szallodalist.Count; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}", szallodalist[i].Nev, szallodalist[i].Ejszakak, szallodalist[i].Szemelyekszam, szallodalist[i].Ellatastipus);
            }

            Console.WriteLine(" Vendegek száma: {0}",szallodalist.Count);



            int osszeg = 0;
            for (int i = 0; i < szallodalist.Count; i++)
            {
                osszeg += szallodalist[i].Ejszakak;
            }
            Console.WriteLine("{0}",osszeg);


            int max = int.MinValue;
            int max1 = int.MinValue;
            for (int i = 0; i < szallodalist.Count; i++)
            {
                if (szallodalist[i].Ejszakak < max)
                {
                    max = szallodalist[i].Ejszakak;
                    max1 = i + 1;
                }
            }
            Console.WriteLine("Max ejszaka: {0}",max);

            Console.ReadKey();

            
          
        }
    }
}
