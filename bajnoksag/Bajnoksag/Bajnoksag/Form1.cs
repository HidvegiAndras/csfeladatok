using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bajnoksag
{
    public partial class Form1 : Form
    {
        private Fajlkezelo csapatokfajlbol = new Fajlkezelo();
        private Csapatlista bajnoksag = new Csapatlista(); //Halmaz        
        private Ideny ideny;
        private List<Merkozes> merkozesek = new List<Merkozes>(); //Ebben tároljuk a mérkőzéseket.
        private List<string> rajtlista = new List<string>();
        private Random rnd = new Random();
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private List<string> statisztika = new List<string>();

        public Form1()
        {
            InitializeComponent();
            statisztika.Add("------- Bajnokság ------");
            statisztika.Add("");
        }        
        
        //Fájlbeolvasás, csapatok benevezése
        private void btn_fajlbeolvas_Click(object sender, EventArgs e)
        {
            string[] bontas = new string[5];

            //Fájlból string list tömbbe - és listboxba
            rajtlista = csapatokfajlbol.CsapatokFajlbol();
            lb_csapatokfajlbol.Items.AddRange(rajtlista.ToArray());

            //Csapatlista betöltés a fájlból kapott tömbből
            for (int i = 0; i < rajtlista.Count; i++)
            {
                bontas = csapatokfajlbol.Sordarabolo(rajtlista[i]);
                bool vane = bajnoksag.Vanilyen(bontas[0]); // Van-e ilyen nevü csapat már nevezve
                if (!vane)
                {
                    Csapat nevezes = bajnoksag.Factory(bontas); //Factory metódus hívása
                    if (nevezes != null)
                    {
                        bajnoksag.egyesuletek.Add(nevezes); //Sikeres nevezés, felvesszük a csapatot a bajnokságba                        
                        lb_bajnoksag.Items.Add(nevezes.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Csapat nem nevezhető: " + rajtlista[i] , "Factory", MessageBoxButtons.OK, MessageBoxIcon.Error); //Nem sikerült benevezni a csapatot valamiért
                    }
                }
                else { MessageBox.Show("Van ilyen csapat: " + bontas[0], "Factory", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }                     
        }

        //Bajnokság (Idény) kezdése
        private void btn_bajnoksagstart_Click(object sender, EventArgs e)
        {
            ideny = new Ideny(tb_bajnoksagneve.Text, bajnoksag.egyesuletek.Count());
            ideny.Folyamatban = true;
            btn_fordulo.Enabled = true;
            lbl_bajnoksaginfo1.Text = ideny.IdenyNev;
            lbl_bajnoksagadatokinfo1.Text = "Csapatok száma: " + ideny.CsapatokSzama;
            lbl_bajnoksagadatokinfo2.Text = "Fordulók száma: " + ideny.FordulokSzama;
            lbl_bajnoksagadatokinfo3.Text = "Meccsek száma:  " + ideny.MeccsekSzama;

            statisztika.Add("Bajnokság neve: "+lbl_bajnoksaginfo1.Text);
            statisztika.Add(lbl_bajnoksagadatokinfo1.Text);
            statisztika.Add(lbl_bajnoksagadatokinfo2.Text);
            statisztika.Add(lbl_bajnoksagadatokinfo3.Text);
            statisztika.Add("");
            statisztika.Add("Benevezett csapatok:");

            //Elkészítjük a bajnokság meccseit.
            int merkozesszam = 1;
            for (int i = 1; i < ideny.FordulokSzama + 1; i++)
            {
                Csapat h = bajnoksag.egyesuletek[ideny.AktualisForduloSzama];
                statisztika.Add(h.ToString());
                for (int j = ideny.AktualisForduloSzama + 1; j < ideny.CsapatokSzama; j++)
                {
                    Csapat v = bajnoksag.egyesuletek[j];
                    Merkozes meccs = new Merkozes(h, v, merkozesszam);
                    merkozesek.Add(meccs);
                    merkozesszam += 1;
                }
                ideny.AktualisForduloSzama += 1;
            }            
            dgv_Bajnoksag.DataSource = bajnoksag.egyesuletek;
            dgv_Bajnoksag.Columns[2].Visible = false; // A Játék értéke, random szám, mindig változik, nem kell látni
        }


        //Bajnoki fordulók / meccsek
        private void btn_fordulo_Click(object sender, EventArgs e)
        {
            statisztika.Add("");
            statisztika.Add("---- Mérkőzések ----");
            //Lejátszuk az előre besorolt meccseket
            foreach (Merkozes m in merkozesek)
            {
                for (int j = 0; j < 8; j++)
                {
                    m.UjJatek();
                }
                m.MerkozesVege();
                statisztika.Add(m.ToString());
                statisztika.AddRange(m.Jatekok);
                statisztika.Add("");
            }



            //Lekönyveljük a bajnokságban
            foreach (Merkozes m in merkozesek)
            {
                foreach (Csapat cs in bajnoksag.egyesuletek)
                {
                    
                    //Hazai és Vendég gólok hozzáadása és mérkőzés szám növelése
                    if (cs.Csapatnev == m.Hazai.Csapatnev) { cs.Lg += m.Hazaigol; cs.Kg += m.Vendegol; cs.M += 1; }
                    if (cs.Csapatnev == m.Vendeg.Csapatnev) { cs.Kg += m.Hazaigol; cs.Lg += m.Vendegol; cs.M += 1; }

                    if (m.Dontetlen)
                    {
                        if (cs.Csapatnev == m.Hazai.Csapatnev) { cs.D += 1; cs.P += 1; }
                        if (cs.Csapatnev == m.Vendeg.Csapatnev) { cs.D += 1; cs.P += 1; }
                    }
                    else
                    {
                        if (cs.Csapatnev == m.Gyoztes.Csapatnev) { cs.Gy += 1; cs.P += 3; }
                        if (cs.Csapatnev == m.Vesztes.Csapatnev) { cs.V += 1; }
                    }
                }
            }

            //Vége a bajnokságnak
            ideny.Folyamatban = false;
            btn_fordulo.Enabled = false;            

            foreach (Merkozes m in merkozesek)
            {
                lb_eredmenyek.Items.Add(m.ToString());
            }

            dgv_Bajnoksag.DataSource = null;            
            bajnoksag.egyesuletek.Sort();
            bajnoksag.egyesuletek.Reverse();
            dgv_Bajnoksag.DataSource = bajnoksag.egyesuletek;
            dgv_Bajnoksag.Columns[2].Visible = false; // A Játék értéke, random szám, mindig változik, nem kell látni

            for (int i = 0; i < bajnoksag.egyesuletek.Count(); i++)
            {
                statisztika.Add((i+1).ToString() +". "+ bajnoksag.egyesuletek[i].Csapatnev +" "+ bajnoksag.egyesuletek[i].M.ToString()+" "+ bajnoksag.egyesuletek[i].Gy.ToString() + " " + bajnoksag.egyesuletek[i].D.ToString() + " " + bajnoksag.egyesuletek[i].V.ToString() + " " + bajnoksag.egyesuletek[i].Lg.ToString() + " " + bajnoksag.egyesuletek[i].P.ToString());
            }
                        
            //csapatokfajlbol.Statisztikairas(statisztika);
            foreach (string s in statisztika)
            {
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            lb_csapatokfajlbol.Items.Clear();
            lb_bajnoksag.Items.Clear();
            bajnoksag.egyesuletek.Clear();
            merkozesek.Clear();
            dgv_Bajnoksag.DataSource = null;
            lb_eredmenyek.Items.Clear();
        }

        private void btn_bajnoksagvege_Click(object sender, EventArgs e)
        {
            MessageBox.Show(statisztika.ToString());
        }
    }
}
