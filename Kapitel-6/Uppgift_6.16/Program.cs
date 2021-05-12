using System;

namespace Uppgift_6._16
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivVertikalt("tjena", 1);
        }

        static void SkrivVertikalt(string text, int rader = 0)
        {

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);

                for (int x = 0; x < rader; x++)
                {
                    Console.WriteLine();
                }
            }



        }
    }
}
