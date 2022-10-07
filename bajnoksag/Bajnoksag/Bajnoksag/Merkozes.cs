using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bajnoksag
{
    class Merkozes
    {
        private Csapat hazai;
        private Csapat vendeg;
        private int hazaigol = 0;
        private int vendegol = 0;
        private Csapat gyoztes;
        private Csapat vesztes;
        private bool dontetlen = false;
        private List<string>jatekok = new List<string>();       
        private Random rnd = new Random();
        private int meccsszama = 0;
       
        public Merkozes(Csapat h, Csapat v, int meccsszam)
        {
            hazai = h;
            vendeg = v;
            meccsszama = meccsszam;
        }    

        public List<string> Jatekok { get { return jatekok; } }
        public int Hazaigol { get { return hazaigol; } }
        public int Vendegol { get { return vendegol; } }
        public Csapat Gyoztes { get { return gyoztes; } }
        public Csapat Vesztes { get { return vesztes; } }
        public bool Dontetlen { get { return dontetlen; } }
        public int Meccsszama { get { return meccsszama; } }
        public Csapat Hazai { get { return hazai; } }
        public Csapat Vendeg { get { return vendeg; } }

        public void UjJatek()
        {            
            int hjatek = hazai.Jatek + rnd.Next(1,100);
            int vjatek = vendeg.Jatek + rnd.Next(1,100);
            string esemeny = "";

            if (hjatek > int.Parse(((vjatek / 4) * 5).ToString()))
            {
                hazaigol += 1;                
                esemeny = hjatek + ":" + vjatek + " Hazai gól";
            }
            else if (vjatek > int.Parse(((hjatek / 4) * 5).ToString()))
            {
                vendegol += 1;                
                esemeny = hjatek + ":" + vjatek + " Vendég gól";                
            }
            else
            {
                esemeny = hjatek + ":" + vjatek + "Mezönyjáték";
            }
            jatekok.Add(esemeny);            
        }

        public void MerkozesVege()
        {
            if (hazaigol > vendegol )
            {
                gyoztes = hazai;
                vesztes = vendeg;
            }
            else if (hazaigol < vendegol)
            {
                gyoztes = vendeg;     
                vesztes = hazai;                
            }
            else
            {
                dontetlen = true;                
            }
        }

        public override string ToString()
        {
            return meccsszama + " " + hazai.Csapatnev + " " + hazaigol + " : " + vendegol + " " + vendeg.Csapatnev;
        }
    }
}
