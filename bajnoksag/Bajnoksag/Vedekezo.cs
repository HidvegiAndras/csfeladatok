using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bajnoksag
{
    class Vedekezo : Csapat
    {
            public Vedekezo(string csnev, string cstaktika, int kertek, int vertek, int csertek) : base(csnev, cstaktika, kertek, vertek, csertek)
            {
                kapusertek = int.Parse(((kertek / 4)*5).ToString());
                vedelemertek = vertek * 2;
                csatarertek = csertek - 10;
            }
    }
}
