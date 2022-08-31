using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onallo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../onallo1/bin/debug/emberek.xml";
            XMLToEmber(path);

            Console.ReadKey();
        }

        //Git komment
        static async void XMLToEmber(string path)
        {
            List<Ember> emberek = await XMLKezelo.XMLToEmber(path);
            foreach (Ember e in emberek)
            {
                Console.WriteLine($"{e.Nev}: {e.SzulDatum.ToShortDateString()} {e.Nem}");
            }
        }
    }
}
