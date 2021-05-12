using System;

namespace Uppgift_6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta program ska räkna ut beräkningar åt dig!");
            string Val = "";
            while (Val != "4")
            {
                SkrivMeny();
                Val = Console.ReadLine();
                Console.WriteLine();

                switch (Val)
                {
                    case "1":
                        MenyAddera();
                        break;

                    case "2":
                        MenySubtrahera();
                        break;

                    case "3":
                        MenyMultiplicera();
                        break;

                    case "4":
                        // Gör ingenting, programmet stängs av
                        break;

                    default:
                        Console.WriteLine("Detta är inte ett tillgängligt val!");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void SkrivMeny()
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Addera två tal");
            Console.WriteLine("2. Subtrahera två tal");
            Console.WriteLine("3. Multiplicera två tal");
            Console.WriteLine("4. Avsluta programmet");
        }

        static void MenyAddera()
        {
            Console.WriteLine("Skriv två tal");

            double tal1 = double.Parse(Console.ReadLine());

            double tal2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
        }

        static void MenySubtrahera()
        {
            Console.WriteLine("Skriv två tal");

            double tal1 = double.Parse(Console.ReadLine());

            double tal2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{tal1} - {tal2} = {tal1 - tal2}");
        }

        static void MenyMultiplicera()
        {
            Console.WriteLine("Skriv två tal");

            double tal1 = double.Parse(Console.ReadLine());

            double tal2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{tal1} * {tal2} = {tal1 * tal2}");
        }
    }
}

