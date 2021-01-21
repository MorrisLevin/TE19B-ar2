using System;

namespace Array_uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dikt = {
           "Jag venne, nån dikt."
       };

            //skriv ut dikten
            //loopa igenom arrayen
            foreach (var rad in dikt)
            {
                Console.WriteLine(rad);
            }

            for (int i = 0; i < dikt.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(dikt[i]);
                }
                else
                {
                    Console.WriteLine(dikt[i] + "n");
                }
            }

        }
    }
}
