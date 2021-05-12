using System;

namespace Uppgift_6._14
{
    class Program
    {
        static Random slump = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Detta program ska slumpa fram en position på ett schackbräde.");
        }

        static int SlumpaRad()
        {
            int rad = slump.Next(1, 9);

            return rad;
        }

        static char SlumpaKolumn()
        {
            string kolumn = "abcdefgh";

            return kolumn[slump.Next(0, 8)];
        }

        static void SlumpaPosition()
        {
            Console.WriteLine($"Den position du fick var{SlumpaRad()}{SlumpaKolumn()}");
        }

    }
}
