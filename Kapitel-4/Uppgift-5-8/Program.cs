using System;

namespace Uppgift_5_8
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Skriv en mening!");
            string mening = Console.ReadLine();

            string[] ord = mening.Split(' ');

            foreach (var orden in mening)
            {
                Console.WriteLine(orden);
            }
        }
    }
}
