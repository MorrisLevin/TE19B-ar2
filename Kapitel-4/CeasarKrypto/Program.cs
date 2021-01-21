using System;

namespace CeasarKrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Låt användaren bestämma antal hoppför varje bokstav
            Console.WriteLine("Väld ett tal mellan 1-9");
            int nummer = int.Parse(Console.ReadLine());

            //Ange en text
            Console.Write("Ange en text: ");
            string text = Console.ReadLine();

            //Loopa igenom inmatad text bokstav för bokstav
            int textlängd = text.Length;
            Console.WriteLine($"Texten är {textlängd} tecken lång.");

            //Loopa igenom bokstav för bokstav
            for (int i = 0; i < textlängd; i++)
            {
                Console.WriteLine($"Loop nr {i}");

                //Plocka ut bokstav på position i
                char bokstav = text[i];
                Console.WriteLine($"Bokstaven på position {i} är {bokstav}");


                //ASCII-värdet för ett tecken
                int ascii = (int)bokstav;
                Console.WriteLine($"Bokstaven {bokstav} har ASCII-värdet {ascii}");




                //Ceasar kryptering
                ascii += nummer;

                //Plocka motsvarande tecken enlight ASCII-tabellen
                char krypteradBokstav = (char)ascii;
                Console.WriteLine($"Bokstaven {bokstav} krypteras till {krypteradBokstav}");
            }
        }
    }
}
