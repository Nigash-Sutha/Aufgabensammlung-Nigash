using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahl 1:");
            int zahl1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zahl 2:");
            int zahl2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zahl   " + "Quersumme   " + "Zahl/Quersumme   ");
            for (int i = zahl1; i <= zahl2; i++)
            {
                int sum = berechneQuersumme(i);

                if (i % sum == 0)
                {
                    Console.Write(i + "\t|");
                    Console.Write(sum + "\t\t|");
                    Console.Write((i / sum) + "\n");
                }
            }
        }
        static int berechneQuersumme(int zahl)
        {
            int sum = 0;
            while (zahl > 0)
            {
                sum += zahl % 10; 
                zahl /= 10;
            }
            return sum;
        }
    }
}
