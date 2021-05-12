using System;

namespace Uppgift_6._13
{
    class Program
    {
        static Random slump = new Random();


        static void Main(string[] args)
        {
            Console.WriteLine("Detta program ska slumpa fram ett år och en månad från 1900-talet.");
            Console.WriteLine($"Det året du fick var {SlumpaÅrtal()}");
            Console.WriteLine($"Den månaden du fick var {SlumpaMånad()}");
        }

        static int SlumpaÅrtal()
        {
            int årtal = slump.Next(1900, 1999);

            return årtal;

        }
        static int SlumpaMånad()
        {
            int månad = slump.Next(1, 12);

            return månad;

        }
    }
}
