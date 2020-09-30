using System;

namespace Projekt_interraktiv_berättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Du vaknar upp i ett rum, utan att veta varför. Det finns 2 dörrar framför dig, vilket rum vill du gå in i? Vänster eller höger?");
            string dörr = Console.ReadLine();

            if (dörr == "vänster")
            {
                //ge val om rum 1
                Console.Write("Du går in i ett tomt rum med en stege och med ett stort hål. Vill du: 1: Klättra upp? Eller 2: Hoppa ner?");

                //välj om du vill klättra eller falla
                string svar1 = Console.ReadLine();

                if (svar1 == "klättra upp")
                {
                    //du väljer att klättra upp
                    Console.Write("Du klättrar upp för stegen. Det fortsätter i över 5 minuter, men till slut börjar du se ljus över dig. Detta kan vara vägen ut.");
                }

                else
                {
                    //du väljer atta falla ner
                    Console.Write("Du väljer att hoppa ner i hålet. Du verkar glida ner för sorts rutschkana. Efter en stund av glidande börjar kanan hetta upp mer och mer. Denna kana verkar inte leda någonstans bra.");
                }




            }
            else
            {
                //ge val om rum 2
                Console.Write("Du går in i ett rum med 2 spakar, en till vänster och en till höger. Vilken drar du i?");

                //välj spak höger eller vänster
                string svar2 = Console.ReadLine();

                if (svar2 == "vänster")
                {
                    //spak vänster
                    Console.Write("När du drar i spak vänster så börjar alla väggar i rumet tryckas mot mitten långsamt. Du verkar inte kunna rubba dom. Och rummet blir mindre och mindre.");
                }

                else
                {
                    //spak höger
                    Console.Write("Du drar i höger spak, och då öppnas en av väggarna. Du kan inte se vad som finns i gången bredvid, men du hör tung andning från någonting som inte verkar mänskligt. ");
                }
            }
        }
    }
}
