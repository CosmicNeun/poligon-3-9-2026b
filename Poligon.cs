using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine("Koliko temena?");
            int n = Convert.ToInt32(Console.ReadLine());
            Poligon novi = new Poligon(n);
            for(int i = 0; i < n; i++)
            {
                novi.teme[i]=new Tacka();
                Console.WriteLine("A[{0}].x:", i + 1);
                novi.teme[i].x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("A[{0}].y:", i + 1);
                novi.teme[i].y = Convert.ToDouble(Console.ReadLine());
            }
            return novi;
        }
        public static void stampa(Poligon novi)
        {
            for (int i = 0; i < novi.broj_temena; i++)
            {
                Console.WriteLine($"a[{i + 1}].x = {novi.teme[i].x}");
                Console.WriteLine($"a[{i + 1}].y = {novi.teme[i].y}");
            }
        }
        public void snimi()
        {
            StreamWriter izlaz = new StreamWriter("poligon.txt");
            izlaz.WriteLine(broj_temena);
            for (int i = 0; i < broj_temena; i++)
            {
                izlaz.WriteLine(teme[i].x);
                izlaz.WriteLine(teme[i].y);
            }
            izlaz.Close();
        }
        public static Poligon ucitaj()
        {
            using (StreamReader ulaz = new StreamReader("poligon.txt"))
            {
                int n = Convert.ToInt32(ulaz.ReadLine());
                Poligon p = new Poligon(n);

                for (int i = 0; i < n; i++)
                {
                    p.teme[i] = new Tacka();
                    p.teme[i].x = Convert.ToInt32(ulaz.ReadLine());
                    p.teme[i].y = Convert.ToInt32(ulaz.ReadLine());
                }

                return p;
            }
        }
        public double Obim()
        {
            double obim=0;
            Vektor a;
            for(int i = 0; i < broj_temena - 1; i++)
            {
                a = new Vektor(teme[i], teme[i + 1]);
                obim += a.duzina();
            }
            a = new Vektor(teme[broj_temena-1], teme[0]);
            obim += a.duzina();
            return obim;
        }
        public bool prost()
        {
            
            return false;
        }
    }
}
