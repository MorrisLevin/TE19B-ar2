using System;

namespace Array_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] städer = new string[3];

            städer[0] = "Stockholm ";
            städer[1] = "Göteborg ";

            Console.WriteLine("Skriv in den sista staden");
            städer[2] = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(städer[i]);
            }
            {

            }
        }
    }
}
