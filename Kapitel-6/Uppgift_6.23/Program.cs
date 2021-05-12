using System;

namespace Uppgift_6._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en text!");
            string meddelande = Console.ReadLine();

            Console.WriteLine(GörVarannanStor(meddelande));
        }

        static string GörVarannanStor(string texten)
        {
            //Gör alla bokstäver små
            texten = texten.ToLower();

            //Dela upp text vid mellanslag
            string[] orden = texten.Split(' ');


            //Loopa igenom texten
            //Plocka ut varannan
            for (int i = 0; i < orden.Length; i += 2)
            {
                orden[i] = orden[i].ToUpper();
            }

            return string.Join(" ", orden);
        }

        static string GörFörstaBokstavStor(string texten)
        {
        
            //Dela upp text vid mellanslag
            string[] orden = texten.Split(' ');


            //Loopa igenom texten
            //Plocka ut varannan
            for (int i = 0; i < orden.Length; i ++)
            {
                orden[i] = orden[1].Substring(0, 1).ToUpper() + orden[i].Substring(1).ToLower();
            }

            return string.Join(" ", orden);

        }
    }
}
