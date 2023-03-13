using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class szalloda
    {
        private string nev;
        private int ejszakak;
        private int szemelyekszam;
        private string ellatastipus;

        public string Nev { get => nev; set => nev = value; }
        public int Ejszakak { get => ejszakak; set => ejszakak = value; }
        public int Szemelyekszam { get => szemelyekszam; set => szemelyekszam = value; }
        public string Ellatastipus { get => ellatastipus; set => ellatastipus = value; }

        public szalloda(string sor)
        {
            string[] dbok = sor.Split(';');
            Nev = dbok[0];
            Ejszakak = Convert.ToInt32(dbok[1]);
            Szemelyekszam = Convert.ToInt32(dbok[2]);
            Ellatastipus = dbok[3];

        }
    }
}
