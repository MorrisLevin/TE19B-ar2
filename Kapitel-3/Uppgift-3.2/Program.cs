

using System;

namespace Uppgift_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
         //Läs in en text, (Usa)
         Console.Write("Vem vann fotbolls-VM för damer 2015? ");
         string vinnare = Console.ReadLine();

         //Sanera inmatningen
         if (vinnare == "usa")
         {
             Console.Writeline("Rätt svar!");
         }
        }
    }
}
