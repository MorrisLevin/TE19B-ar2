using System;

namespace Exempel_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en text att kryptera!");
            string meddelande = Console.ReadLine();

            Console.WriteLine($"Krypterat med 1 steg:{CeasarKryptera(meddelande)}");
            Console.WriteLine($"Krypterat med 1 steg:{CeasarKryptera(meddelande, 3)}");
        }

        ///<summary>
        ///
        ///<summary/>
        ///<param name="text">><param/>
        ///<param name="nyckel">><param/>
        ///<returns><returns/>

        static string CeasarKryptera(string text, int nyckel = 1)
        {
            string textKrypterat = "";
            for (int i = 0; i < text.Length; i++)
            {
                char tecken = text[i];

                int Kod = (int)tecken;


                int KodKrypterat = Kod + nyckel;


                char teckenKrypterat = (char)KodKrypterat;

                textKrypterat += teckenKrypterat;
            }

            return textKrypterat;
        }
    }
}
