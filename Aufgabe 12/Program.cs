﻿using System;
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

            for (int i = 0; i < zahlen.Length; i++)
            {
                resultat[i] = int.Parse(zahlen[i]);
            }

            Console.WriteLine($"\nResultat:");
            SumUp(resultat);

            Console.ReadKey();
        }
        static int[] SumUp(int[] zahlen)
        {
            int[] resultat = new int[zahlen.Length];
            int summe = 0;

            for (int i = 0; i < zahlen.Length; i++)
            {
                summe += zahlen[i];
                resultat[i] = summe;
                Console.WriteLine("[" + i + "] -> " + resultat[i]);
            } return resultat;
        }
    }
}
