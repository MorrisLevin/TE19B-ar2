using System;

namespace Uppgit_Testprov
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;


            Console.WriteLine("Du ska behöva lösa ett matteproblem. x * 6 = 42. Vad är x?");

            double svar = x * 6;
            while (x == 0)
            {
                string input = Console.ReadLine();

                if (double.TryParse(input, out x))
                {
                    Console.WriteLine("Bra, du skrev ett tal.");
                }
                else
                {
                    Console.WriteLine("Skriv ett tal!");
                }

                if (x == 7)
                {
                    Console.WriteLine("Rätt svar, du får 1 poäng.");
                }
                else
                {
                    Console.WriteLine("Fel svar " + x + "* 6 = " + svar);
                }
            }
        }
    }
}