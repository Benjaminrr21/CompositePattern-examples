using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern2
{
    public abstract class DivElement
    {
        public abstract void PodesiSirinu(double sirina);
        public abstract void PodesiMargine(double t,double r,double b, double l);
        public abstract void ObojPozadinu(string color);
        public abstract void Ispis();

    }
}
