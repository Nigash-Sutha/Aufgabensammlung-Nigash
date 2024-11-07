using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahlen.\n");
           
            Console.WriteLine("Nenne Mir die erste Zahl!\n");
            string input = Console.ReadLine();
            int zahl1 = Convert.ToInt32(input); 


            Console.WriteLine("Nenne Mir die zweite Zahl!\n");
            input = Console.ReadLine();
            int zahl2 = Convert.ToInt32(input);

            Console.WriteLine("Summe = " + (zahl1 + zahl2));

            Console.ReadKey();
        }
    }
}
