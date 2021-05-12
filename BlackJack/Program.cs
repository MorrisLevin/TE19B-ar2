using System;

namespace BlackJack
{
    class Program
    {
        static Random slump = new Random();
        static void Main(string[] args)
        {

            string svar = "";

            while (svar != "n")
            {
                Console.WriteLine("Welcome to the game BlackJack. Would you like to begin? y = yes n = no");
                svar = Console.ReadLine();

                if (svar == "y")
                {
                    Console.WriteLine("OK, then you can start!");
                }
                else
                {
                    break;
                }
static void 
                Console.WriteLine($"First, we have player 1. Plaayer 1, your first card is: {SlumpaKort()}";

             static int SlumpaKort()
        {
            int rad = slump.Next(1, 10);

            return rad;
        }

            }
        }
    }
}
