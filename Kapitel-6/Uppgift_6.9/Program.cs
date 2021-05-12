using System;

namespace Uppgift_6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett decimaltal!");

            double tal = ReadDouble();

            Console.WriteLine($"Du skrev talet {tal}");
        }

        static double ReadDouble()
        {

            double svar = 0.0;
            if (!double.TryParse(Console.ReadLine(), out svar))
            {
                Console.WriteLine("Du skrev ej ett decimaltal, försök igen.");
            }
            else
            {
                Console.WriteLine("Bra, du skrev ett decimaltal.");
            }
            return svar;

        }
    }
}
