using System;

namespace Uppgift_6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string längreord = längst("Hej", "Hejsan");
            Console.WriteLine(längreord);
        }

        static string längst(string text1, string text2)
        {

            if (text1.Length > text2.Length)
            {
                return text1;
            }
            else
            {
                return text2;
            }

        }
    }
}
