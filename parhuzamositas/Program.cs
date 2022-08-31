using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parhuzamositas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParhuzamosBeolvasas();
            SimaBeolvasas(ConsoleColor.Green, 1, "fajl1.txt");
            Console.ReadKey();
        }

        private static void SimaBeolvasas(ConsoleColor szin, int szal, string fileUt)
        {
            StreamReader file = new StreamReader(fileUt);
            while (!file.EndOfStream)
            {
                Console.ForegroundColor = szin;
                Console.WriteLine($"[{szal}. szal] - {file.ReadLine()}");
            }
        }

        private static async void ParhuzamosBeolvasas()
        {
            await FelolvasEsKiir(ConsoleColor.Red, 2, "fajl2.txt");
        }

        static Task FelolvasEsKiir(ConsoleColor szin, int szal, string fileUt)
        {
            return Task.Run(() =>
            {
                StreamReader file = new StreamReader(fileUt);
                while (!file.EndOfStream)
                {
                    Console.ForegroundColor = szin;
                    Console.WriteLine($"[{szal}. szal] - {file.ReadLine()}");
                }
            });
        }
    }
}
