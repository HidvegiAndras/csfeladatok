using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Oroklodes
{
    class Negyzet
    {
        protected int x; //bal felső sarok x,y koordinálta
        protected int y;
        protected int oldalhossza;

        public Negyzet(int x, int y, int oldalhossza)
        {
            this.x = x;
            this.y = y;
            this.oldalhossza = oldalhossza;

        }

        public void Rajzol (Graphics g)
        {
            Pen p = new Pen(Color.Red, 3);
            g.DrawRectangle(p, x, y, oldalhossza, oldalhossza);
        }
    }
}
