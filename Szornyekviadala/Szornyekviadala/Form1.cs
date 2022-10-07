using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szornyekviadala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Fajlkezelo Szornyekafajlbol = new Fajlkezelo();
        Halmaz Szornyekhalamza = new Halmaz();       
        List<string> szornylista = new List<string>();
        Random rnd = new Random();

        private void btn_beolvas_Click(object sender, EventArgs e)
        {
            string[] bontas = new string[3];
            Szorny gyartasbol;            

            //Fájlból string list tömbbe
            szornylista = Szornyekafajlbol.Szornybeolvastombbe(); 
            lb_szornyfajllista.Items.AddRange(szornylista.ToArray());

            //Szörnyek hozzáadása a halmazhoz
            for (int i = 0; i < szornylista.Count; i++)
            {
                bontas = szornylista[i].Split(':');
                bool vane = Szornyekhalamza.Vanilyen(bontas);
                if ( !vane )
                {
                    gyartasbol = Szornyekhalamza.Factory(bontas); //Factory metódus hívása
                    if (gyartasbol != null)
                    {
                        Szornyekhalamza.szornyekhalmaza.Add(gyartasbol);
                        lb_besorozva.Items.Add(gyartasbol.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Nincs ilyen szörnyosztály: " + bontas[0], "Factory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { MessageBox.Show("Van ilyen szörny: " + bontas[0]+" "+bontas[1], "Factory", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }                    
        }

        //Szörnyek küzdelme az Arénában:
        private void btn_kuzdelem_Click(object sender, EventArgs e)
        {
            if (Szornyekhalamza.szornyekhalmaza.Count() >= 2) //TODO:Innen hiányzik, hogy ne legyen duplikáció
            {
                int random1 = rnd.Next(Szornyekhalamza.szornyekhalmaza.Count());
                int random2 = rnd.Next(Szornyekhalamza.szornyekhalmaza.Count());
                Szorny harcos1 = Szornyekhalamza.szornyekhalmaza[random1];
                Szorny harcos2 = Szornyekhalamza.szornyekhalmaza[random2];                

                //Berakjuk az arénába:
                lb_arena.Items.Clear();
                lb_arena.Items.Add(Szornyekhalamza.szornyekhalmaza[random1].ToString());
                lb_arena.Items.Add(Szornyekhalamza.szornyekhalmaza[random2].ToString());

                //Megy a harc a Megkuzd a vesztes id-jét adja vissza:
                int gyoztes;
                int vesztes = Szornyekhalamza.Megkuzd(harcos1, harcos2);
                if (vesztes == random1) { gyoztes = random2; } else { gyoztes = random1; }

                //Kihirdetjük a győztest és kap +3 tapasztalati pontot:
                lbl_gyoztes.Text = "Gyöztes: " + Szornyekhalamza.szornyekhalmaza[gyoztes].ToString();
                Szornyekhalamza.szornyekhalmaza[gyoztes].Tapasztalat = Szornyekhalamza.szornyekhalmaza[gyoztes].Tapasztalat + 3;

                //Vesztes a temetőbe és kivesszük a szörnyek halmazából:
                lb_elhunyt.Items.Add(Szornyekhalamza.szornyekhalmaza[vesztes].ToString());
                Szornyekhalamza.szornyekhalmaza.RemoveAt(vesztes); 

                //Maradék küzőképes szörnyek listája:
                lb_besorozva.Items.Clear();
                for (int i = 0; i < Szornyekhalamza.szornyekhalmaza.Count(); i++)
                {
                    lb_besorozva.Items.Add(Szornyekhalamza.szornyekhalmaza[i].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nincs elég szörny besorozva", "Küzdelem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ujszorny_Click(object sender, EventArgs e)
        {
            string[] bontas = new string[3];
            Szorny gyartasbol;

            bontas = tb_ujszorny.Text.Split(':');
            bool vane = Szornyekhalamza.Vanilyen(bontas);           
            if (!vane)
            {
                gyartasbol = Szornyekhalamza.Factory(bontas); //Factory metódus hívása
                if (gyartasbol != null)
                {
                    Szornyekhalamza.szornyekhalmaza.Add(gyartasbol);
                    lb_besorozva.Items.Add(gyartasbol.ToString());
                }
                else
                {
                    MessageBox.Show("Nincs ilyen szörnyosztály: " + bontas[0], "Factory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Van ilyen szörny: " + bontas[0] + " " + bontas[1], "Factory", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
