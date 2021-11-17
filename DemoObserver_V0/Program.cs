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
            eau.Attach(alexandre);
            eau.Attach(benjamin);

            eau.Prix = .80;
        }
    }
}
