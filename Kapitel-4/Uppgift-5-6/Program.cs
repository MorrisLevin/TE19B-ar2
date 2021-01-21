using System;

namespace Uppgift_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 5 städer!");
            string[] städer = new string[5];

            for (int i = 0; i < städer.Length; i++)
            {
                Console.WriteLine("Ange en stad!");
               städer[i] Console.ReadLine();
            }


            foreach (var stad in städer)
            {
                Console.WriteLine(stad);
            }

        }
    }
}
