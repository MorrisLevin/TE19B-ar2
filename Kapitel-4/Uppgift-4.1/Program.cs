using System;

namespace Uppgift_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string land = "";

            while (land != "Kina")

            {
                Console.WriteLine("Vad är världens folkrikaste land?");

                land = Console.ReadLine();

                if (land != "Kina")
                {
                    Console.WriteLine("Fel svar, försök igen.");

                }
                else
                {
                    Console.WriteLine("Rätt svar!");
                }
            }
        }
    }
}