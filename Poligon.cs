using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_3_9_2026b
{
    internal class Poligon
    {
        public int broj_temena;
        public Tacka[] teme;
        public Poligon(int n) 
        {
            broj_temena = n;
            teme = new Tacka[n];
        }
        public static Poligon unos()
        {
            return null;
        }
        public void stampa()
        {
            Console.WriteLine();
        }
        public void snimi()
        {

        }
        public static Poligon ucitaj()
        {
            return null;
        }
    }
}
