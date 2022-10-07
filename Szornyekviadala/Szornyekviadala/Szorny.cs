using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szornyekviadala
{
    abstract class Szorny : IComparable<Szorny>
    {
        //Adattagok
        protected int tamadaspont;
        protected int tapasztalatpont;
        protected string szornynev;
        protected string sztipus;
        private Random rnd = new Random();

        // Konstruktor
        public Szorny(string szornytipus, string sznev, int exp)
        {
            szornynev = sznev;
            tapasztalatpont = exp;
            sztipus = szornytipus;            
        }

        //Tulajdonságok
        public int Tamadas { get { return tamadaspont; } }
        public int Tapasztalat { get { return tapasztalatpont; } set { tapasztalatpont = value; } }        
        public string Szornyosztaly { get { return sztipus; } set { sztipus = value; } }
        public string Nev { get { return szornynev; } set { szornynev = value; } }
        public int Tamadasertek { get { if (tamadaspont < 10) { return tamadaspont + rnd.Next(10); } else { return tamadaspont + rnd.Next(Tamadas); } } }

        //Metódusok
        public int CompareTo(Szorny value) // itt mit kell csinálni?
        {
            return this.szornynev.CompareTo(value.szornynev);
        }
        
        public override string ToString()
        {
            return Szornyosztaly+","+Nev+","+Tapasztalat+","+Tamadas+",("+Tamadasertek+")";
        }                   
    }    
}
