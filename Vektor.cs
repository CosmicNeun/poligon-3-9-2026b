using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_3_9_2026b
{
    internal class Vektor
    {
        Tacka pocetak,kraj;
        public Vektor(Tacka a, Tacka b)
        {
            pocetak = a;
            kraj = b;
        }
        public Tacka Centriraj()
        {
            Tacka nova = new Tacka(kraj.x-pocetak.x,kraj.y-pocetak.y);
            return nova;
        }
    }
}
