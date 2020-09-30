using System;

namespace Uppgift_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double höjd = 0;
            double rekord = 0;
            double skillnad = 0;
            string meddelande = "";


            Console.Write("Hur högt kan du hoppa i höjdhopp? ");
            höjd = double.Parse(Console.ReadLine());

            Console.Write("Det är högt, men rekorded är ");
            rekord = double.Parse(Console.ReadLine());

            skillnad = rekord - höjd;



            meddelande = "Hej, du kan hoppa " + höjd + "meter, men rekordet är  " + rekord + "meter, vilket är en " + skillnad + " meters skillnad.";

            Console.WriteLine(meddelande);
        }
    }
}
