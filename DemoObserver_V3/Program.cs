using DemoObserver.Models;
using System;

namespace DemoObserver
{
    public class Program
    {
        static void Main(string[] args)
        {
            Acheteur alexandre = new Acheteur("Alexandre");
            Acheteur benjamin = new Acheteur("Benjamin");

            Produit eau = new Produit("Eau 33cl");
            eau.Attach(alexandre.Reagit);
            eau.Attach(benjamin.Reagit);

            eau.Prix = .80;



        }
    }
}
