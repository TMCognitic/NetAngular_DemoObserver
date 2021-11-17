using DemoObserver.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.Models
{
    public class Produit : Subject
    {
        private double _prix;

        public double Prix
        {
            get { return _prix; }
            set 
            {
                if(_prix != value)
                {
                    _prix = value;
                    Notify();
                }
                
            }
        }

        public string Nom { get; private set; }

        public Produit(string nom)
        {
            Nom = nom;
        }
    }
}
