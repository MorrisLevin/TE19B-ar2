using System;

namespace Uppgift_5._12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meningar = { "Mitt favoritspel är Dark Souls.", "Min favoritmat är Pad Thai.", "Jag gillar att träna?", "Jag vet inte riktigt vad jag ska skriva mer." };

            foreach (string mening in meningar)
            {
                Console.WriteLine(mening);
                Console.WriteLine();
            }

        }
    }
}