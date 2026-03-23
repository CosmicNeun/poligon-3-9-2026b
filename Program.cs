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
            /*Tacka a = new Tacka(4, 5);
            Tacka b = new Tacka(5, 5);
            Tacka prva = new Tacka(3,2);
            Tacka druga = new Tacka(7, 6);
            Vektor A = new Vektor(prva, druga);
            Console.WriteLine(Ravan.sis(A,a,b));
            Console.ReadLine();*/
            Poligon prvi = Poligon.unos();
            prvi.snimi();
        }
    }
}
