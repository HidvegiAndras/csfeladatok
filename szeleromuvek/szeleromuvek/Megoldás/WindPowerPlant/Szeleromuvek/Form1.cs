using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szeleromuvek
{
    public partial class Form1 : Form
    {
        private List<Megye> megyek = new List<Megye>();
        private List<Szeleromu> szelEromuvek = new List<Szeleromu>();
        

        public Form1()
        {
            InitializeComponent();           


            /***************************************************************** 
            * 
            1. Olvassa be és tárolja el az adatokat a szöveges állományokból!
            *
            *****************************************************************/

            //Megye fájl felolvasás
            List<string> megyekFajlTartalom = Fajlkezelo.Felolvasas("megye.txt");            
            foreach (var sor in megyekFajlTartalom)
            {
                string[] bontas = Fajlkezelo.Sordarabolo(sor, '\t');
                Megye megye = new Megye();
                megye.MegyeNev = bontas[0];
                megye.Regio = bontas[1];                
                megyek.Add(megye);
            }

            //Erőművek fájl felolvasása
            List<string> eromuvekkFajlTartalom = Fajlkezelo.Felolvasas("szeleromu.txt");            
            foreach (var sor in eromuvekkFajlTartalom)
            {
                string[] bontas = Fajlkezelo.Sordarabolo(sor, ';');
                Szeleromu eromu = new Szeleromu();
                eromu.TelepulesNev = bontas[0];
                eromu.MegyeNev = bontas[1];
                eromu.RegioNev = bontas[2];
                eromu.TornyokSzama = int.Parse(bontas[3]);
                eromu.ToronyTeljesitmenyKW = int.Parse(bontas[4]);
                eromu.EpitesEve = int.Parse(bontas[5]);
                szelEromuvek.Add(eromu);
            }

            //Eredmény stringek
            string eredmenyLabel = "";
            string[] eredmenyList;            

            

            /***************************************************************** 
            * 
            4. Átlagosan hány tornyot építettek a Nyugat-Dunántúl régióban? Az értéket pontosan 2 tizedes jeggyel jelenítse meg! (Minden olyan építés külön számít, amelyben más volt a tornyok építési éve, vagy a teljesítménye.)
            *
            *****************************************************************/
            List <Szeleromu> nyugatDunantuliEromuvek = szelEromuvek.Where(x => x.RegioNev == "Nyugat-Dunántúl").ToList();            
            double atlagosToronyszam = Math.Round(nyugatDunantuliEromuvek.Average(x => x.TornyokSzama), 2);

            /***************************************************************** 
            * 
            5. Épült-e torony a dél-alföldi régióban? Ha igen, akkor adjon meg egy ilyen településnevet, ha nem, akkor írja ki, hogy nem épült ebben a régióban torony!
            *
            *****************************************************************/
            string delalfoldieredmeny = "Nem épült torony ebben a régióban";
            if (szelEromuvek.Any(x => x.RegioNev == "Dél-Alföld"))
            {
                delalfoldieredmeny = szelEromuvek.Where(x => x.RegioNev == "Dél-Alföld").FirstOrDefault().TelepulesNev;
            }

            /***************************************************************** 
            * 
            6. Adja meg a Vas megyében épült tornyok településeit, darabszámát, teljesítményét és építési évét!
            *
            *****************************************************************/
            List<Szeleromu> vasMegyeiEromuvek = szelEromuvek.Where(x => x.MegyeNev == "Vas").ToList();

            /***************************************************************** 
            * 
            7.Hány építkezés folyt az Észak-Alföld és a Dél - Alföld régiókban összesen?
            *
            *****************************************************************/
            List<Szeleromu> alfoldiEpitkezesek = szelEromuvek.Where(x => x.RegioNev == "Dél-Alföld" || x.RegioNev == "Észak-Alföld").ToList();


            /***************************************************************** 
            * 
            8. Adja meg az összes olyan település nevét, amelyikben épült már szélerőmű! Minden település csak egyszer szerepeljen, és a kiírás névsorban történjen!
            *
            *****************************************************************/
            List<string> telepulesekEromuvel = szelEromuvek.Select(x => x.TelepulesNev).ToList();
            telepulesekEromuvel = telepulesekEromuvel.Distinct().ToList();
            telepulesekEromuvel.Sort();


            /***************************************************************** 
            * 
            9. Adja meg a Veszprém megyében mely években épült szélerőmű!
            *
            *****************************************************************/
            List<int> epitesiEvekVeszpremMegyeben = szelEromuvek.Where(x => x.MegyeNev == "Veszprém").Select(x => x.EpitesEve).Distinct().ToList();

            /***************************************************************** 
            * 
            10. Adja meg emelkedő sorrendben azokat az éveket, amikor Veszprém megyében és Győr-Moson-Sopron megyében is épültek szélerőművek! Minden évszám csak egyszer szerepeljen!
            *
            *****************************************************************/
            List<int> epitesiEvekGYMSMegyeben = szelEromuvek.Where(x => x.MegyeNev == "Győr-Moson-Sopron" ).Select(x => x.EpitesEve).Distinct().ToList();
            List<int> kozosEvek = epitesiEvekGYMSMegyeben.Intersect(epitesiEvekVeszpremMegyeben).ToList();


            /***************************************************************** 
            * 
            11. Adja meg azoknak a megyéknek a nevét névsorban, amelyekben még nem épültek szélerőművek!
            *
            *****************************************************************/



            /***************************************************************** 
            * 
            12.Adja meg megyénként a tornyok számát!Csak azokat a megyéket jelenítse meg, amelyekben épült szélerőmű!
            *
            *****************************************************************/
            //List<int> tornyokSzamaMegyenkent = 
                      

        }


        /***************************************************************** 
        * 
        2. Adja meg, hány torony épült összesen eddig Magyarországon!
        *
        *****************************************************************/
        
        private void feladat2_Click(object sender, EventArgs e)
        {
            int tornyokSzamaOsszesen = szelEromuvek.Sum(x => x.TornyokSzama);
            lbl_eredmeny.Text = "Magyarországon eddig " + tornyokSzamaOsszesen.ToString() + " torony épült.";
        }


        /***************************************************************** 
        * 
        3. Adja meg, hogy melyik településen és melyik évben épült a legtöbb torony!
        *
        *****************************************************************/

        private void feladat3_Click(object sender, EventArgs e)
        {
            int legtobbTorony = szelEromuvek.Max(x => x.TornyokSzama);
            string legtobbToronyTelepulesen = szelEromuvek.Where(x => x.TornyokSzama == legtobbTorony).FirstOrDefault().TelepulesNev;
            int legtobbToronyEv = szelEromuvek.Where(x => x.TornyokSzama == legtobbTorony).FirstOrDefault().EpitesEve;
            lbl_eredmeny.Text = "A legtöbb torony " + legtobbToronyTelepulesen + " településén épült " + legtobbToronyEv.ToString() + " -ban/ben" + "(" + legtobbTorony.ToString() + ")";
        }
    }
}
