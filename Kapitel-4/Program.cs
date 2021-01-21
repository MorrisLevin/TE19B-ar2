using System;

namespace kapitel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //slumpa tal från 1-6
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 7);

            //uppreda tills rätt svar har gissats
            while (true)
            {
                //läs in användarens gissning
                Console.WriteLine("Gissa ett tal (1-6)");
                int gissning = int.Parse(Console.ReadLine());

                //om användaren har gissat rätt?
                if (gissning == slumptal)
                {
                    Console.WriteLine("Rätt gissat!");
                    break;
                }
                else
                {
                    Console.WriteLine("Fel gissat, försök igen.");
                }
            }
        }
    }
}
