using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bajnoksag
{
    class Csapatlista
    {
        public List<Csapat> egyesuletek = new List<Csapat>();

        public Csapat Factory(string[] team)
        {
            switch (team[1].Trim())
            {
                case "Jokapus":
                    Jokapus ujcsapatjokapus = new Jokapus(team[0], team[1], int.Parse(team[2]), int.Parse(team[3]), int.Parse(team[4]) );
                    return ujcsapatjokapus;
                case "Vedekezo":
                    Vedekezo ujcsapatvedekezo = new Vedekezo(team[0], team[1], int.Parse(team[2]), int.Parse(team[3]), int.Parse(team[4]));
                    return ujcsapatvedekezo;
                case "Tamado":
                    Tamado ujcsapattamado = new Tamado(team[0], team[1], int.Parse(team[2]), int.Parse(team[3]), int.Parse(team[4]));
                    return ujcsapattamado;
                default:
                    return null;
            }
        }
        
        public bool Vanilyen(string csnev)
        {
            for (int i = 0; i < egyesuletek.Count(); i++) { if (csnev == egyesuletek[i].Csapatnev) { return true; } } return false;
        }
    }
}
