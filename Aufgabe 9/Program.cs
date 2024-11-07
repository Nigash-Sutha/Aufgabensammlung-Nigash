using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string bin = "";
                int n = 0;
                Console.WriteLine("Ganzzahlige Dezimalzahl (q to Quit):");
                string eingabe = Console.ReadLine();
                if (eingabe.ToLower() == "q")
                {
                    break;
                }

                n = Convert.ToInt32(eingabe);
                while (n != 0)
                {
                    int rest = n % 2;
                    bin = rest + bin;
                    int wert = n / 2;
                    n = wert;
                }
                Console.WriteLine("Binär: {0}\n", bin);
            }
            Environment.Exit(0);
        }
    }
}



