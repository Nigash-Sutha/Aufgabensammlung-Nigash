using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_12_alt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Zahlen Aufsummieren");
            Console.WriteLine("-------------------");
            Console.WriteLine("\nGeben Sie die zu summierenden Ganzzahlen mit Komma getrennt ein: ");

            string eingabe = Console.ReadLine();

            string[] zahlen = eingabe.Split(',');

            int[] zahlenArray = new int[zahlen.Length];
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlenArray[i] = Convert.ToInt32(zahlen[i]);
            }

            int[] resultat = sumUp(zahlenArray);

            Console.WriteLine("Resultat Array: " + string.Join(", ", resultat));

            int summe = 0;
            for (int i = 0; i < zahlenArray.Length; i++)
            {
                summe += zahlenArray[i];
            }

            Console.WriteLine("Gesamtsumme: " + summe);

            Console.ReadKey();
        }

        static int[] sumUp(int[] zahlen)
        {
            int[] resultat = new int[zahlen.Length];
            int summe = 0;

            for (int i = 0; i < zahlen.Length; i++)
            {
                summe += zahlen[i];
                resultat[i] = summe;
            }

            return resultat;
        }
    }
}

