using System;

namespace MorseTolk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berätta om programmet
            Console.WriteLine("Det här programmet översätter din text till morsekod.");
            //Be om ett meddelande
            Console.WriteLine("Ange ett meddelande");
            string meddelande = Console.ReadLine();



            //Loopa igenom meddelandet
            for (int i = 0; i < meddelande.Length; i++)
            {
                //Skriv in varje tecken
                string bokstav = meddelande[i].ToString();

                //För säkerhets skull omvandla till versaler
                bokstav = bokstav.ToUpper();


                //Skapa en samling för alfabetet
                string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

                //Hitta bokstavens plats i alfabetet
                int index = alfabetet.IndexOf(bokstav);


                //Skapa en samling om morsekode (array)
                string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", " " };

                //Skriv ut morsekoden för bokstaven
                string morseBokstav = morse[index];
                Console.Write($" {morseBokstav}");
            }


        }
    }
}
