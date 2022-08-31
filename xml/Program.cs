using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Ember> emberek = new List<Ember>();
            //emberek.Add(new Ember("Kiss Lajos", "kl@gmail.com", 23, true));
            //emberek.Add(new Ember("Nagy Adrienn", "na@citromail.hu", 43, false));
            //emberek.Add(new Ember("Kovacs Laszlo", "ka@yahoo.com", 34, true));

            //XMLKezelo.EmberToXml(emberek, "emberek.xml");

            List<Ember> emberekXMLbol = XMLKezelo.XMLToEmber("emberek.xml");
            foreach (Ember e in emberekXMLbol)
            {
                Console.WriteLine(e.Kiir());
            }

            Console.ReadKey();
        }
    }
}
