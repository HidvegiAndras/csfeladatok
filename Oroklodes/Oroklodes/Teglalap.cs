using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Oroklodes
{
    class Teglalap : Negyzet
    {
        protected int oldalhosszb;

        public Teglalap(int x, int y, int oldalhossza, int oldalhosszb) : base (x,y,oldalhossza)
        {
            this.oldalhosszb = oldalhosszb;

        }

        public new void Rajzol(Graphics g)
        {
            Pen p = new Pen(Color.Red, 3);
            g.DrawRectangle(p, x, y, oldalhossza, oldalhosszb);
        }
    }
}
