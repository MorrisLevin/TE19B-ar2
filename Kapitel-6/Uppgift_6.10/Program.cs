using System;

namespace Uppgift_6._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv vad som helst");
            HelTal();
        }
        static void HelTal();

        int svar = 0;

  if (!int.TryParse(Console.ReadLine(), out svar))
            {
                Console.WriteLine("Du skrev ett heltal.");
            }
            else
            {
                Console.WriteLine("Du skrev inte ett heltal.");
            }
            return svar;

    }
}
