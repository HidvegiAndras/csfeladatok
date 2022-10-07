using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szornyekviadala
{
    class Ogre : Szorny
    {
        public Ogre(string szornytipus, string sznev, int exp) : base(szornytipus, sznev, exp)
        {
            tamadaspont = exp * 2;
        }
    }
}
