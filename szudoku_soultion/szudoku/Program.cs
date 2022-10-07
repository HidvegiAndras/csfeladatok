using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            var fs = new FileStream("feladvanyok.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fs, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    lista.Add(line);
                }
            }

            // Console.WriteLine(lista.Count);

            Feladvany sor0 = new Feladvany(lista[65]);

            Console.WriteLine(sor0.Meret);
            sor0.Kirajzol();
           
            int hanyas = Console.Read();


            Console.WriteLine(hanyas);
            Console.ReadKey();

   
        }  
        


    } 
}
