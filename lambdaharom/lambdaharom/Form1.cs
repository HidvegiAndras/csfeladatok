using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lambdaharom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int MAX = 60;

        struct Versenyzo
        {
            public string nev;
            public int ervenytelen, ervenyes;
        }

        Versenyzo[] verseny = new Versenyzo[MAX];

        int n = 0;

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            n = 0;
            lb1.Items.Clear();
            
            if(File.Exists("alkoto.txt"))
            {
                StreamReader sr = new StreamReader("alkoto.txt", Encoding.UTF8);
                try
                {
                    while(!sr.EndOfStream && n < MAX)
                    {
                        verseny[n].nev = sr.ReadLine();

                        string[] szavazatok = sr.ReadLine().Split(' ');

                        verseny[n].ervenytelen = int.Parse(szavazatok[0]);
                        verseny[n].ervenyes = int.Parse(szavazatok[1]);

                        lb1.Items.Add(verseny[n].nev + " (Összes szavazat: " + (verseny[n].ervenyes).ToString() + " Érvényes: " + verseny[n].ervenytelen.ToString() + ")");

                        n++;
                    }
                }
                catch
                {
                    MessageBox.Show("Hiba történt a fájlból beolvasás során.");
                }
                finally
                {
                    if(rb1 != null)
                    {
                        sr.Close();
                    }
                }
                gb1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nincs meg a fájl.");
            }
        }

        private void Rb1_CheckedChanged(object sender, EventArgs e)
        {
            lb2.Items.Clear();
            int eredmeny = verseny.Sum(x => x.ervenyes);
            lb2.Items.Add("Az érvényes szavazatok száma: " + eredmeny.ToString());

        }

        private void Rb2_CheckedChanged(object sender, EventArgs e)
        {
            lb2.Items.Clear();

            //double eredmeny = verseny.Average(x => x.ervenytelen);

            double eredmeny = verseny.Take(n).Average(x => x.ervenytelen);
            lb2.Items.Add("Az érvénytelen szavazatok átlaga: " + eredmeny.ToString("0.00"));
        }

        private void Rb3_CheckedChanged(object sender, EventArgs e)
        {
            lb2.Items.Clear();

            int max = verseny.Max(x => x.ervenyes);
            Versenyzo ertek = verseny.First(x => x.ervenyes == max);

            lb2.Items.Add("A legtöbb érvényes szavazatot kapó versenyző neve: " + ertek.nev);
            lb2.Items.Add("Érvényes szavazatainak száma: " + ertek.ervenyes.ToString());
            lb2.Items.Add("Érvénytelen szavazatainak száma: " + ertek.ervenytelen.ToString());
        }

        private void Rb4_CheckedChanged(object sender, EventArgs e)
        {
            lb2.Items.Clear();

            bool vane = Array.Exists(verseny, x => x.ervenytelen > 10);
            if (vane)
            {
                lb2.Items.Add("Van 10-nél több érvénytelen szavazatot szerző tanuló.");

                string nev = verseny.First(x => x.ervenytelen > 10).nev;
                lb2.Items.Add(nev);
            }
            else
            {
                lb2.Items.Add("Nincs 10-nél több érvénytelen szavazatot szerző tanuló.");
            }
        }

        private void Rb5_CheckedChanged(object sender, EventArgs e)
        {
            lb2.Items.Clear();
            try
            {
                int max = verseny.Where(x => x.ervenytelen == 0).Max(x => x.ervenyes);
                string nev2 = verseny.First(x => x.ervenytelen == 0 && x.ervenyes == max).nev;
                lb2.Items.Add(nev2);
            }
            catch
            {
                lb2.Items.Add("Nincs olyan cwersenyző, akinek nincs érvénytelen szavazata");
            }
        }

        private void Rb6_CheckedChanged(object sender, EventArgs e)
        {
            lb2.Items.Clear();
            Array.ForEach(verseny.Where(x => x.ervenyes >= 50).ToArray(), x => lb2.Items.Add(x.nev + " (" + x.ervenyes.ToString() + " szavazat)"));
        }

        private void Rb7_CheckedChanged(object sender, EventArgs e)
        {
            lb2.Items.Clear();

            Versenyzo[] rendezett = verseny.OrderByDescending(x => x.ervenyes).Where(x => (x.nev != null)).ToArray();
            Array.ForEach(rendezett, x => lb2.Items.Add(x.nev + " (" + x.ervenyes.ToString() + " szavazat)"));
        }
    }
}
