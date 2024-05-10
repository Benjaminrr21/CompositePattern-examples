using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern2
{
    public class NavigationBar : DivElement
    {

        public List<DivElement> Tabs { get; set; }
        public string Id { get; set; }

        public NavigationBar(string id)
        {
            Tabs = new List<DivElement>();
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
        public void AddTab(DivElement tab)
        {
            Tabs.Add(tab);
        }
        public void RemoveTab(DivElement tab)
        {
            Tabs.Remove(tab);
        }
        public override void Ispis()
        {
            Console.WriteLine($"Parent div sa ID-em: {Id} ima sledece tabove:");
            foreach (var tab in Tabs)
            {
                tab.Ispis();
            }
        }
    }
}
