using System;

namespace Slumpbetyg
{
    class Program
    {
        static void Main(string[] args)
        {

            Random tärning = new Random();

            int slumptal = tärning.Next(0, 7);
            Console.WriteLine($"Slumptalet = {slumptal}");

            if (slumptal == 0)
                Console.WriteLine("Du fick betyget F!");
            if (slumptal == 1)
                Console.WriteLine("Du fick betyget E!");
            if (slumptal == 2)
                Console.WriteLine("Du fick betyget D!");
            if (slumptal == 3)
                Console.WriteLine("Du fick betyget C!");
            if (slumptal == 4)
                Console.WriteLine("Du fick betyget B!");
            if (slumptal == 5)
                Console.WriteLine("Du fick betyget A!");

            switch (slumptal)
            {
                case 1:
                    Console.WriteLine("Du fick betyget E!");
                    break;
                case 2:
                    Console.WriteLine("Du fick betyget D!");
                    break;
                case 3:
                    Console.WriteLine("Du fick betyget C!");
                    break;
                case 4:
                    Console.WriteLine("Du fick betyget B!");
                    break;
                case 5:
                    Console.WriteLine("Du fick betyget A!");
                    break;

                default:
                    Console.WriteLine("Du fick betyget F!");
                    break;
            }

            string[] betyg = { "F, E, D, C, B, A"};

        }
    }
}
