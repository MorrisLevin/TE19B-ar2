using System;

namespace Uppgift_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivBaklänges("Tjena!");
            SkrivBaklänges("Alla dessa textet skrivs baklänges.");
            SkrivBaklänges("!räh ned nevÄ");
        }
        static void SkrivBaklänges(string meddelande)
        {
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.Write(meddelande[i]);
            }
            Console.WriteLine();
        }
    }
}
