using System;

namespace Uppgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal.");
            string text = Console.ReadLine();

            int summan = 0;
            for (int i = 0; i < text.Length; i++)
            {
                string nummer = text[i].ToString();
                int tal = int.Parse(nummer);
                summan += tal;
            }
            Console.WriteLine($"Siffersumman av talet {text} är {summan}");
        }
    }
}
