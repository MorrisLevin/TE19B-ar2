using System;

namespace Uppgift_6._20
{
    class Program
    {
        static void Main(string[] args)
        {
            string menyVal = "";
            while (menyVal != "3")
            {
                // Skriv ut huvudmenyn
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Addera 3 tal");
                Console.WriteLine("2. Största talet av 2 tal");
                Console.WriteLine("3. Avsluta programmet");
                menyVal = Console.ReadLine();

                switch (menyVal)
                {

                    case "1":
                        MenyValAddera();
                        break;

                    case "2":
                        MenyValStörstaTalet();
                        break;

                    case "3":
                        break;

                    default:
                        Console.WriteLine("Det går inte. Försök igen!");
                        break;
                }
            }
        }

        static void MenyValAddera()
        {
            Console.WriteLine("Skriv 3 tal att addera");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            int tal3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Addera(tal1, tal2, tal3));
        }

        static void MenyValStörstaTalet()
        {
            Console.WriteLine("Skriv 2 hela tal att jämföra");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Störst(tal1, tal2));
        }

        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }


        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }

        }
    }
}
