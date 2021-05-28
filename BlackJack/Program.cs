using System;

namespace BlackJack
{
    class Program
    {
        static Random slump = new Random();

        static void Main(string[] args)
        {
            //Skapa en array med klädda kort
            string[] kläddkort = new string[] { "Queen", "King", "Jack" };

            // Generera ett slumpmässigt index som är mindre än storleken på arrayen.
            int randomkläddkort = slump.Next(kläddkort.Length);


            //Skapa en array fylld med kortfärger
            string[] färg = new string[] { "of spades", "of cloves", "of clubs", "of hearts" };

            // Generera ett slumpmässigt index som är mindre än storleken på arrayen.
            int randomfärg = slump.Next(färg.Length);


            //Skapa en int som samlar båda spelarnas värde
            int[] total = { 0, 0 };

            //Förklara reglerna av BlackJack
            Console.WriteLine("Welcome to the game BlackJack.\nThe rules are:\n1. You will draw multiple random cards.\n2. With these cards you have to get them to as close to the number 21.\n3. If you go over the number 21, you lose. Player 1 starts with a random card.");


            //While loop som ser till att total[i] värde inte blir högre än 21
            for (int i = 0; i < total.Length; i++)
            {
                while (total[i] <= 21) // resten
                {

                    //Int för att dra ett random kort med ett random värde
                    int kort = SlumpaKort();


                    //Total[i] samlar värderna från int kort
                    total[i] += kort;


                    //Om total[i] värde blir över 21, så vinner spelare 2
                    if (total[i] > 21)
                    {
                        Console.WriteLine($"Your value was {total[i]} That value is over 21, You lost, Player {i + 0} wins.");
                        break;
                    }



                    //Bestämmer hur äss fungerar
                    if (kort == 1)
                    {
                        Console.WriteLine("You got an ace. Choose between 1 and 11. 1 = a 11 = b");
                        string ace = Console.ReadLine();

                        if (ace == "a")
                        {
                            kort = 1;
                        }
                        else if (ace == "b")
                        {
                            total[i] = total[i] + 10;
                        }
                    }

                    //Förklarar vilket kort man får/vilket värde ens total har. Frågar också om man vill dra ett till kort. Ser också till så att om man får nummer 10 så kan man få ett klädd kort.
                    if (kort != 10)
                    {


                        Console.WriteLine($"The card you got was the {kort} {färg[randomfärg]}. Your value is now {total[i]}. Do you want another card? y = yes n = no ");
                        string svar = Console.ReadLine();

                        if (svar == "n")
                        {
                            Console.WriteLine($"Ok, now player {i + 2}, your turn.");
                            break;
                        }
                    }


                    else
                    {
                        kort = 10;
                        Console.WriteLine($"The card you got was the {kläddkort[randomkläddkort]} {färg[randomfärg]}. Your value is now {total[i]}. Do you want another card? y = yes n = no ");
                        string svar = Console.ReadLine();
                        if (svar == "n")
                        {
                            Console.WriteLine($"Ok, now player {i + 2}, your turn.");



                            break;
                        }
                    }
                }
            }


            if (total[0] == total[1])
            {
                Console.WriteLine("It's a draw!");
            }
            else if (total[0] > total[1] && total[0] <= 21)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
            }


        }
        //Metod som ger ut värdet till korten, mellan 1 och 10
        static int SlumpaKort()
        {
            int nummer = slump.Next(1, 11);

            return nummer;
        }




    }
}


