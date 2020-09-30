using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Läs in ålder
            Console.WriteLine("Hur gammal är du? (Svara i hela antal år) ");
            int ålder = int.Parse(Console.ReadLine());

            // Om ålder = 18 skriv myndig 
            if (ålder >= 18)
            {
                Console.WriteLine("Du är myndig. Du får ta körkort.");
            }

            // Om ålder är 15 eller högre
            if (ålder >= 15)
            {
                System.Console.WriteLine("Du får köra moped!");
            }

            // Om åldern är lägre än 15, skriv du är för ung för att köra moped
            if (ålder < 15)
            {
                System.Console.WriteLine("Du är för ung!");
            }

            // Läs in en text
            Console.Write("Vem var statsmenister i Sverige 1970? ");
            string statsmenister = Console.ReadLine();


            // Sanera inmatningen
            statsmenister = statsmenister.ToLower();
            if (statsmenister == "palme")
            {
                Console.WriteLine("Rätt svar!");

            }
            else {
            
                Console.WriteLine("Fel svar!");
            }
        }
    }
}
