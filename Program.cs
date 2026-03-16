using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_3_9_2026b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jovan Katancevic
            Tacka a = new Tacka(3, 2);
            Tacka b = new Tacka(-2, 3);
            Tacka o = new Tacka();
            Vektor oa = new Vektor(o, a);
            Vektor ob = new Vektor(o, b);
            Console.WriteLine(Vektor.VP(oa, ob));
            Console.ReadLine();
        }
    }
}
