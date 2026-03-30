using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_3_9_2026b
{
    internal class Tacka
    {
        public double x, y;
        public Tacka()
        {
            x = 1;
            y = 1;
        }
        public Tacka(double a, double b)
        {
            x = a;
            y = b;
        }
        public double d()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public static bool jednake(Tacka a, Tacka b)
        {
            return (a.x==b.x) && (a.y==b.y);
        }
    }
}
