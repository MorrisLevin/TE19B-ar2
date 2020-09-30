
using System;

namespace Uppgift_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn = "Morris";

            Console.WriteLine("Mitt namn är" + namn );

            //Mha variabelsubstition
            Console.WriteLine($"Mitt namn är {namn}");

            string svar = $"Mitt förnamn är {namn}. ";
            Console.WriteLine(svar);
            System.Console.WriteLine();
            
            Console.Writeline();
        }
    }
}
