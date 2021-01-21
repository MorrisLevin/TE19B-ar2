using System;
using System.IO;

namespace P2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett av dessa två alternativ: ");
            Console.WriteLine("1. Skapa qen fil/skriva över en fil");
            Console.WriteLine("2. Läs in innehållet ur en fil");
            string val = Console.ReadLine();

            Console.WriteLine("Skriv in filens namn");
            string namn = Console.ReadLine();

            switch (val)
            {
                case "1":
                    Console.WriteLine("Skriv in en mening som ska läggas in till filen");
                    string mening = Console.ReadLine();
                    File.WriteAllText(namn, mening);
                    break;

                case "2":
                    if (File.Exists(namn))
                    {
                        string innehåll = File.ReadAllText(namn);
                        Console.WriteLine("Detta är filens innehåll:");
                        Console.WriteLine(innehåll);
                    }
                    else
                    {
                        Console.WriteLine("Denna fil finns tyvärr inte");
                    }
                    break;

                default:
                    break;
            }
        }
    }
}