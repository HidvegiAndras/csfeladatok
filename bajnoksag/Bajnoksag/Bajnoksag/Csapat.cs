using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bajnoksag
{
    class Csapat : IComparable<Csapat>
    {
        public Random rnd;

        protected string csapatnev;
        protected string csapattaktika;
        protected int kapusertek;
        protected int vedelemertek;
        protected int csatarertek;

        protected int m = 0;
        protected int gy = 0;
        protected int d = 0;
        protected int v = 0;
        protected int lg = 0;
        protected int kg = 0;
        protected int p = 0;

        public Csapat(string csnev, string cstaktika, int kertek, int vertek, int csertek)
        {
            csapatnev = csnev;
            csapattaktika = cstaktika;
            kapusertek = kertek;
            vedelemertek = vertek;
            csatarertek = csertek;
        }

        public string Csapatnev { get { return csapatnev; } }
        public string Csapattaktika { get { return csapattaktika; } }
        public int Jatek  { get { rnd = new Random();  return kapusertek + vedelemertek + csatarertek + rnd.Next(1, 75); } }
        public int M { get { return m; } set { m = value; } }
        public int Gy { get { return gy; } set { gy = value; } }
        public int D { get { return d; } set { d = value; } }
        public int V { get { return v; } set { v = value; } }
        public int Lg { get { return lg; } set { lg = value; } }
        public int Kg { get { return kg; } set { kg = value; } }
        public int P { get { return p; } set { p = value; } }

        public override string ToString()
        {
            return csapatnev + " " +", K:" + kapusertek + ", V:" + vedelemertek + ", CS:" + csatarertek +", Ö:" + (kapusertek + vedelemertek + csatarertek).ToString();
        }

        public int CompareTo(Csapat value) // Rendezés szerzett pont szerint, ha egyforma, névsor szerint ))
        {
            {
                if (this.P == value.P)
                {
                    return this.csapatnev.CompareTo(value.csapatnev);
                }             
                return this.P.CompareTo(value.P);
            }
        }
    }
}
