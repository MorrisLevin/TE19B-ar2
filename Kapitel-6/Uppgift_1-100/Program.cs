using System;

namespace Uppgift_1_100
{
    class Program
    {
        static void Main(string[] args)
        {


            int talet = int.Parse(Console.ReadLine());

            //   Console.WriteLine("Ange ett tal 1-100");
            //  int.TryParse(Console.ReadLine());

            Console.WriteLine("Vilket bord vill du ändra på?");
            int bordNr = ReadInt();
            Console.WriteLine($"Du valde bord {bordNr}");

        }
        static int ReadInt()
        {
            int svar = 0;
            while (!int.TryParse(Console.ReadLine(), out svar))    //! == false
            {
                Console.WriteLine("Heltal inte inmatat, vg försök igen");
            }
            return svar;
        }
    }
}
