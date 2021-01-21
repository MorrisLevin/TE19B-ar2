using System;

namespace Array_Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många sporter har du provat?");
            int nummer = int.Parse(Console.ReadLine());
          string[] sporter = new string[nummer];
            
            for (int i = 0; i < nummer; i++)
            {
                Console.WriteLine("Skriv en sport.");
                sporter[i] = Console.ReadLine();
            }
            Console.WriteLine("Dina sporter var: ");
            for (int i = 0; i < nummer; i++)
            {
                Console.WriteLine(sporter[i]);
            }
        }
    }
}
