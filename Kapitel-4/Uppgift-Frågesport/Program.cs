using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn = "";

            string svar = "";

            //Fråga användaren om sitt namn
            Console.WriteLine("Vad är ditt namn?");
            namn = Console.ReadLine();

            while (svar != "b")
            {

                //Berätta för användaren om vad dem ska göra
                Console.WriteLine("Hej " + namn + ". Detta är en frågesport. Du kommer behöva svara på en fråga, och gissa mellan 3 svar. a, b eller c.");
                Console.WriteLine("Vem håller världsrekordet för axelpress? (216 kg)");
                Console.WriteLine("a = Hafthor Björnsson");
                Console.WriteLine("b = Eddie Hall");
                Console.WriteLine("c = Brian Shaw");
                svar = Console.ReadLine();

                if (svar == "b")
                {
                    Console.WriteLine("Rätt svar, det var Eddie Hall.");
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
