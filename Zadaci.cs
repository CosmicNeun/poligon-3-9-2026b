using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_3_9_2026b
{
    internal class Zadaci
    {
        public static void Deltoid(Poligon n)
        {
            Vektor ab = new Vektor(n.teme[0], n.teme[1]);
            Vektor bc = new Vektor(n.teme[1], n.teme[2]);
            Vektor cd = new Vektor(n.teme[2], n.teme[3]);
            Vektor da = new Vektor(n.teme[3], n.teme[0]);

            double ab_l = ab.duzina();
            double bc_l = bc.duzina();
            double cd_l = cd.duzina();
            double da_l = da.duzina();

            if ((ab_l == da_l && bc_l == cd_l) || (ab_l == bc_l && cd_l == da_l))
            {
                Console.WriteLine("Jeste deltoid");
            }
            else
            {
                Console.WriteLine("Nije deltoid");
            }
        }
        public static void Pravougaonik(Poligon n)
        {
            Vektor ab = new Vektor(n.teme[0], n.teme[1]);
            Vektor bc = new Vektor(n.teme[1], n.teme[2]);
            Vektor cd = new Vektor(n.teme[2], n.teme[3]);
            Vektor da = new Vektor(n.teme[3], n.teme[0]);

            if (Vektor.SP(ab, bc) == 1 && Vektor.SP(bc, cd) == 1 && Vektor.SP(cd, da) == 1 && Vektor.SP(da, ab) == 1)
            {
                Console.WriteLine("Jeste pravougaonik");
            }
            else
            {
                Console.WriteLine("Nije pravougaonik");
            }
        }
        public static void Trapez(Poligon n)
        {
            Vektor ab = new Vektor(n.teme[0], n.teme[1]);
            Vektor bc = new Vektor(n.teme[1], n.teme[2]);
            Vektor cd = new Vektor(n.teme[2], n.teme[3]);
            Vektor da = new Vektor(n.teme[3], n.teme[0]);

            if ((Vektor.SP(ab, bc) == 1 && Vektor.SP(bc, cd) == 1) || (Vektor.SP(bc, cd) == 1 && Vektor.SP(cd, da) == 1) || (Vektor.SP(cd, da) == 1 && Vektor.SP(da, ab) == 1))
            {
                Console.WriteLine("Jeste trapez");
            }
            else
            {
                Console.WriteLine("Nije trapez");
            }
        }
    }    
}