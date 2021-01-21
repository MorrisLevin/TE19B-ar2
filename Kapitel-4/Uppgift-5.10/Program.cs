using System;

namespace Uppgift_5._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] karta = new string[5, 2];
            karta[0, 0] = "Skog";
            karta[1, 0] = "Träsk";
            karta[2, 0] = "Berg";
            karta[3, 0] = "Berg";
            karta[4, 0] = "Skog";
            karta[0, 1] = "Träsk";
            karta[1, 1] = "Skog";
            karta[2, 1] = "Skog";
            karta[3, 1] = "Skog";
            karta[4, 1] = "Träsk";

            Console.WriteLine("Skriv en X-koordinat (0 - 4)");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv en Y-koordinat (0 - 1)");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"På den rutan du valde finns {karta[x, y]}");
        }
    }
}