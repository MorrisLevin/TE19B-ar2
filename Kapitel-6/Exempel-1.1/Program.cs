using System;

namespace Exempel_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi skriver text vertikalt!");


            SkrivVertikalt("Metoder!");

            SkrivVertikalt("Metoder är kul!");

            SkrivVertikalt("Mycket användbart i programmering!");

        }
        static void SkrivVertikalt(string text1)
        {

            for (int i = 0; i < text1.Length; i++)
            {
                Console.WriteLine(text1[i]);
            }
        }
    }


