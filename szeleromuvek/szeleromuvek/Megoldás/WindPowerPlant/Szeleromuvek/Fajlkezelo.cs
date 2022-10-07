using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szeleromuvek
{
    static class Fajlkezelo
    {
        static public List<string> Felolvasas(string fajlnev)
        {
            List<string> lista = new List<string>();
            var fs = new FileStream(fajlnev, FileMode.Open, FileAccess.Read);
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

        static public string[] Sordarabolo(string sor, char szeparator)
        {
            {
                string[] bontas = sor.Split(szeparator);
                return bontas;
            }
        }
    }
}
