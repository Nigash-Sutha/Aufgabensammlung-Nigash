using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Aufgabe_12
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

            int[] resultat = new int[zahlen.Length];

            
           
            //hallo


            int summe = 0;

            for (int i = 0; i < zahlen.Length; i++)
            {
                summe = summe + Convert.ToInt32(zahlen[i]);
            }

            


            Console.WriteLine("Resultat: " + summe);


            Console.ReadKey();
        }
    }
}
