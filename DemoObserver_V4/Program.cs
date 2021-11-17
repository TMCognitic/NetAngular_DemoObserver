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

            Produit coca = new Produit("Coca 33cl");
            Produit eau = new Produit("Eau 33cl");
            eau.Broadcast += alexandre.Reagit;
            eau.Broadcast += benjamin.Reagit;

            eau.Prix = .80;



        }
    }
}
