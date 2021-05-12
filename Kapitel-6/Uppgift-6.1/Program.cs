using System;

namespace Uppgift_6._1
{
    class Program
    {
        static void Main(string[] args)
        {

            SkrivTalKvadrat(2);
            SkrivTalKvadrat(5);
            SkrivTalKvadrat(10);
        }

        static void SkrivTalKvadrat(int tal)
        {
            Console.WriteLine($"Talet {tal} upphöjt till 2 blir {tal * tal}");
        }
    }
}
