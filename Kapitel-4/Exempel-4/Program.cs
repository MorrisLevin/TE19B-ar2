using System;

namespace Exempel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Slumpa fram ett tal(1-6)
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 7);

            //deklarera variabeln
            int gissning = 0;

            //loopar tills vi får rätt tal
            while (gissning != slumptal)
            {
                //Fråga användaren vad hen gissar
                Console.WriteLine("Gissa ett tal.(1-6)");

                string input = Console.ReadLine();

                if (int.TryParse(input, out gissning))
                {
                    Console.WriteLine("Vad bra att du matade in ett tal.");

                    //Kolla om gissning är rätt
                    if (gissning != slumptal)
                    {
                        Console.WriteLine("Fel svar. Försök igen.");
                    }

                }
                else
                {
                    Console.WriteLine("Nej, jag bad om ett tal.");
                }

            }
            //Rätt svar!
            Console.WriteLine("Rätt svar!");
        }
    }
}
