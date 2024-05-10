using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern2
{
    public class Tab : DivElement
    {
        public string Id { get; set; }
        

        public Tab(string id)
        {
            Id = id;
        }

        public override void ObojPozadinu(string color)
        {
            Console.WriteLine($"Pozadina diva sa ID-em {Id} je obojena u {color}\n");
            
        }

        public override void PodesiMargine(double t, double r, double b, double l)
        {
            Console.WriteLine($"Margine diva sa ID-em: {Id}:\nGornja margina: {t}\nDonja margina: {b}\nLeva margina: {l}\nDesna margina: {r}\n");
        }

        public override void PodesiSirinu(double sirina)
        {
            Console.WriteLine($"Sirina diva sa ID-em {Id} je {sirina}\n");
        }
        public override void Ispis()
        {
            Console.WriteLine($"Tab sa ID-em: {Id}\n");
        }
    }
}
