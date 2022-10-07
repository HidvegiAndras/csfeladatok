using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bajnoksag
{
    class Jokapus : Csapat
    {
        public Jokapus(string csnev, string cstaktika, int kertek, int vertek, int csertek) : base(csnev, cstaktika, kertek, vertek, csertek)
        {
            kapusertek = kertek * 2;
            vedelemertek = vertek + 10;
            csatarertek = int.Parse(((csertek / 4) * 3).ToString());
        }
    }
}
