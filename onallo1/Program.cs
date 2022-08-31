using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onallo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ember> emberek = new List<Ember>()
            {
                new Ember("Kiss Lajos", new DateTime(1961, 5, 13), true),
                new Ember("Nagy Adrienn", new DateTime(1994, 11, 24), false),
                new Ember("Toth Laszlo", new DateTime(1987, 1, 5), true)
            };

            ToXML(emberek, "emberek.xml");

            Console.ReadKey();
        }

        static async void ToXML(List<Ember> emberek, string path)
        {
            await XMLKezelo.EmberToXML(emberek, path);
        }
    }
}
