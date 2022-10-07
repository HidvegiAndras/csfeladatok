using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Szornyekviadala
{
    class Fajlkezelo
    {
        public Fajlkezelo()
        {}               

        public List<string> Szornybeolvastombbe()
        {
            List<string> lista = new List<string>();
            var fs = new FileStream("szornyek.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fs, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    lista.Add(line);
                }
            }
            return lista;            
        }

        public string[] Sordarabolo(string sor)
        {
            {
                string[] bontas = sor.Split(':'); 
                return bontas;
            }            
        }
    }
}
