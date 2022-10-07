using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Bajnoksag
{
    class Fajlkezelo
    {
        public Fajlkezelo()
        { }

        public List<string> CsapatokFajlbol()
        {
            List<string> lista = new List<string>();
            var fs = new FileStream("csapatok.txt", FileMode.Open, FileAccess.Read);
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
                string[] bontas = sor.Split(',');
                return bontas;
            }
        }
    }
}
