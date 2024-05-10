using CompositePattern2;
using System;
using System.Collections.Generic;
namespace CompositePattern
{
    /// <summary>
    /// Composite Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Tab logoTab = new Tab("#logo-tab");
            NavigationBar nb = new NavigationBar("#navbar");
            Tab item1 = new Tab("#home");
            Tab item2 = new Tab("#about");
            Tab item3 = new Tab("#contact");

            nb.AddTab(item1); 
            nb.AddTab(item2); 
            nb.AddTab(item3);

            Console.WriteLine("SAMOSTALNI OBJEKAT:\n");
            logoTab.Ispis();
            logoTab.ObojPozadinu("green");
            logoTab.PodesiMargine(2.4, 3.4, 1.4, 2.0);

            Console.WriteLine("GRUPNI OBJEKAT:\n");
            nb.Ispis();
            nb.PodesiMargine(3.5, 2.5, 3, 5);
            Console.ReadKey();
        }
    }
}