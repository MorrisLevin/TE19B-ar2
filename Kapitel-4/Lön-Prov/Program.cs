using System;

namespace Lön_Prov
{
    class Program
    {
        static void Main(string[] args)
        {

            double marginalskatt = 0;



            //Fråga användaren om bruttolönen!
            Console.WriteLine("Mata in bruttolönen!");
            int bruttolön = int.Parse(Console.ReadLine());

            double nettolön = 0;

            //Räkna ut marginalskatten ur bruttolönen
            if (bruttolön < 10000)
            {
                nettolön = bruttolön * 0.92;

                marginalskatt = 8;
            }
            else if (bruttolön <= 144999)
            {
                nettolön = bruttolön * 0.78;
                marginalskatt = 22;
            }
            else if (bruttolön <= 514999)
            {
                nettolön = bruttolön * 0.67;
                marginalskatt = 33;
            }
            else if (bruttolön >= 515000)
            {
                nettolön = bruttolön * 0.47;
                marginalskatt = 53;
            }
            {
                //skriv vad en nettolön och marginalskatt är!
                Console.WriteLine("Din nettolön är " + nettolön + " och din marginalskatt är " + marginalskatt + "%");
            }
        }
    }
}

