using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bajnoksag
{
    class Ideny
    {
        private string idenynev;
        private int csapatokszama;
        private int meccseksszama = 0;
        private int fordulokszama;
        private int aktualisforduloszama = 0;
        private int lejatszottmeccsekszama = 0;
        private bool folyamatban = false;

        public string IdenyNev { get { return idenynev; } }
        public int CsapatokSzama { get { return csapatokszama; } }
        public int MeccsekSzama { get { return meccseksszama; } }
        public int FordulokSzama { get { return fordulokszama; } }
        public int LejatszottMeccsekSzama { get { return lejatszottmeccsekszama; } set { lejatszottmeccsekszama = value; } }
        public int AktualisForduloSzama { get { return aktualisforduloszama; } set { aktualisforduloszama = value; } }
        public bool Folyamatban { get { return folyamatban; } set { folyamatban = value; } }
        
        public Ideny(string _indenynev, int _csapatokszama)
        {
            this.idenynev = _indenynev;
            this.csapatokszama = _csapatokszama;
            this.fordulokszama = _csapatokszama - 1;
            for (int i = 0; i < csapatokszama; i++)
            {
                this.meccseksszama += fordulokszama - i;  
            }
        }
    }
}
