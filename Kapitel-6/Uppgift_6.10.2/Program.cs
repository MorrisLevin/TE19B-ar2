using System;

namespace Uppgift_6._10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv vad som helst!");
            string text = Console.ReadLine();

            int tal;
            if (!int.TryParse(Console.ReadLine(), out tal))
            {
                Console.WriteLine("Du skrev inte ett heltal. Försök igen.");
            }
            else
            {
                Console.WriteLine("Du skrev ett heltal.");
            }
        }
    }
}
