using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berechnung der Anzahl Sekunden eines Monats");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Wieviele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?\n");

            string eingabe = Console.ReadLine();
            int tage;

            if (int.TryParse(eingabe, out tage))
            {
                Console.WriteLine("Ihre Eingabe " + tage.ToString() + " ist gültig.");
                int sekunden = tage * 24 * 60 * 60;
                Console.WriteLine($"Die Anzahl der Sekunden in {tage} Tagen beträgt {sekunden} Sekunden.");
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine gültige Zahl ein.");
            }

            Console.ReadKey();
        }
    }
}
