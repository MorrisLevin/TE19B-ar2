using System;
using System.IO;

namespace Filhantering2
{
    class Program
    {
        static void Main(string[] args)
        {

            string filnamn = "./animals (1).txt";

            string[] rader = File.ReadAllLines(filnamn);

            Console.Write("Ange sökterm (Första bokstaven):");

            string sökterm = Console.ReadLine();

            int radNr = 1;

            foreach (var rad in rader)
            {
                if (rad.Substring(0, 1) == sökterm)
                {

                    radNr++;
                }
            }



            Console.WriteLine($"Antal djur {radNr - 1} djur");

        }
    }
}
