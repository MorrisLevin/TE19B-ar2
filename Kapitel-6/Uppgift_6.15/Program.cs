using System;

namespace Uppgift_6._15
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivBaklänges(5.2);
        }

        static void SkrivBaklänges(string meddelande)
        {

            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.Write(meddelande[i]);
            }

        }

        static void SkrivBaklänges(int tal)
        {
            SkrivBaklänges(tal.ToString());
        }

        static void SkrivBaklänges(double tal)
        {
            SkrivBaklänges(tal.ToString());
        }
    }
}
