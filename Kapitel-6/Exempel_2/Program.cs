using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int talet = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange ett tal 1-100");
            int.TryParse(Console.ReadLine());
        }
    }
}
