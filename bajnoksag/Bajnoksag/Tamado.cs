using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bajnoksag
{
    class Tamado : Csapat
    {
        public Tamado(string csnev, string cstaktika, int kertek, int vertek, int csertek) : base(csnev, cstaktika, kertek, vertek, csertek)
        {
            kapusertek = int.Parse(((kertek / 4) * 5).ToString());
            vedelemertek = vertek - 20;
            csatarertek = int.Parse(((csertek / 2) * 5).ToString());
        }
    }
}
