using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szornyekviadala
{
    class Halmaz
    {
        public List<Szorny> szornyekhalmaza = new List<Szorny>();

        public Szorny Factory(string[] monsta)
        {
            switch (monsta[0])
            {
                case "Ork":
                    Ork newmonstaork = new Ork(monsta[0], monsta[1], int.Parse(monsta[2]));                   
                    return newmonstaork;                                      
                case "Troll":
                    Troll newmonstatroll = new Troll(monsta[0], monsta[1], int.Parse(monsta[2]));
                    return newmonstatroll;                    
                case "Ogre":
                    Ogre newmonstaogre = new Ogre(monsta[0], monsta[1], int.Parse(monsta[2]));
                    return newmonstaogre;
                default:
                    return null;
            }
        }        

        public bool Vanilyen(string[] bontas)
        {
            for (int i = 0; i < szornyekhalmaza.Count(); i++)
            {
                if (bontas[0] == szornyekhalmaza[i].Szornyosztaly && bontas[1] == szornyekhalmaza[i].Nev )
                {
                    return true;
                }                
            }
            return false;
        }

        public int Megkuzd( Szorny aszorny, Szorny bszorny) //a vesztest adom vissza
        {
            if (aszorny.Tamadasertek > bszorny.Tamadasertek) { return szornyekhalmaza.IndexOf(bszorny); } else { return szornyekhalmaza.IndexOf(aszorny); }
        } 
    }
}
