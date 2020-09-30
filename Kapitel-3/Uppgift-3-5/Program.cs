//För att få åka en viss berg-och-dalbana på en nöjespark så måste man vara mellan 1,5 och 1,9 meter lång. Skapa ett program som frågar användaren hur lång hen är och sedan skriver ut om hen får åka berg-och-dalbanan eller inte.

using System;

namespace Uppgift_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Läs in längd
            Console.Write("Hur lång är du? ");
            double längd = double.Parse(Console.ReadLine());
            //Svara om man får åka eller inte   
            if (1.5 < längd && längd < 1.9)
            {
                Console.Writeline("Du får åka berg-o-dalbana!");
            }
            else
            {
                Console.Writeline("Du får inte åka!");
            }
        }
    }
}
}
