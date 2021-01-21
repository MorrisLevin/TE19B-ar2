using System;

namespace Uppgift_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "";
            double nummer1 = 0;
            double nummer2 = 0;

            while (val != 3)
            {
                Console.WriteLine("Välj ett av 3 val.");
                Console.WriteLine("1. Omvanda meter till kilometer.");
                Console.WriteLine("2. Omvanda kilometer till meter.");
                Console.WriteLine("3. Avsluta programmet.");


                val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        Console.WriteLine("Hur många meter ska bli kilometer?");
                        nummer1 = double.Parse(Console.WriteLine());
                        nummer1 = nummer1 / 1000;
                        Console.WriteLine("det blir" + nummer1 + "km");
                        break;

                    case "2":
                        Console.WriteLine("Hur många kilometer ska bli meter?");
                        nummer2 = double.Parse(Console.WriteLine());
                        nummer2 = nummer1 * 1000;
                        Console.WriteLine("det blir" + nummer2 + "m");
                        break;
                    default: break;
                }

            }
        }
    }
}
