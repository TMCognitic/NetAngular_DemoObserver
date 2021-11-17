using DemoObserver.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.Models
{
    public class Acheteur : IObserver
    {
        public string Nom { get; private set; }

        public Acheteur(string nom)
        {
            Nom = nom;
        }

        public void Update(ISubject subject)
        {
            if(subject is Produit p)
                Console.WriteLine($"{Nom} - {p.Nom} change de prix : {p.Prix}");
        }
    }
}
