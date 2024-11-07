using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahlen.\n");
            Console.WriteLine("Nenne Mir die erste Zahl!\n");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nenne Mir die zweite Zahl!\n");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Summe = {Zahl1 + Zahl2}");
            Console.ReadKey();
        }
    }
}