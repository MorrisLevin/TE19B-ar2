//Ett kafé utlyser en kampanj där personer äldre än 65 år samt personer mellan 10 och 18 erbjuds att köpa kaffe till ett extra billigt pris. Skriv ett program som innehåller endast en if-sats som undersöker om användaren kan få köpa kaffe extra billigt.
using System;

namespace Uppgift_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Läs in ålder
            Console.Write("Hur gammal är du? ");
            int ålder = int.Parse(Console.ReadLine());

            //Svara om man får extrapris eller inte
            if (ålder >= 65 || (ålder > 10 && ålder < 18)) 
            {
            Console.Write("Du får kaffe extra billigt!");          
        }
            else
                {
                    Console.Write("Du får inte extra billigt kaffe.");
                }
            }
        }
    }