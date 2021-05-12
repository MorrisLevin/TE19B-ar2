using System;

namespace Filmprov
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filmer = new string[50]
{ "1: Avatar från 2009 ",
 "2: Titanic från 1997 ",
 "3: Star Wars: The Force Awakens från 2015 ",
 "4: Avengers: Infinity War från 2018 ",
 "5: Jurassic World från 2015 ",
 "6: Avengers: Endgame film currently playing från 2019 ",
 "7: The Avengers från 2012 ",
 "8: Furious 7 från 2015 ",
 "9: Avengers: Age of Ultron från 2015 ",
 "10: Black Panther från 2018" ,
 "11: Harry Potter and the Deathly Hallows - Part 2 från 2011 ",
 "12: Star Wars: The Last Jedi från 2017 ",
 "13: Jurassic World: Fallen Kingdom från 2018 ",
 "14: Frozen från 2013 ",
 "15: Beauty and the Beast från 2017 ",
 "16: Incredibles 2 från 2018 ",
 "17: The Fate of the Furious från 2017 ",
 "18: Iron Man 3 från 2013 ",
 "19: Minions från 2015 ",
 "20: Captain America: Civil War från 2016 ",
 "21: Aquaman film currently playing från 2018 ",
 "22: Transformers: Dark of the Moon från 2011 ",
 "23: The Lord of the Rings: The Return of the King från 2003 ",
 "24: Captain Marvel film currently playing från 2019 ",
 "25: Skyfall från 2012 ",
 "26: Transformers: Age of Extinction från 2014 ",
 "27: The Dark Knight Rises från 2012 ",
 "28: Toy Story 3 från 2010 ",
 "29: Pirates of the Caribbean: Dead Man's Chest från 2006 ",
 "30: Rogue One: A Star Wars Story från 2016 ",
 "31: Pirates of the Caribbean: On Stranger Tides från 2011 ",
 "32: Despicable Me 3 från 2017 ",
 "33: Jurassic Park från 1993 ",
 "34: Finding Dory från 2016 ",
 "35: Star Wars: Episode I - The Phantom Menace från 1999 ",
 "36: Alice in Wonderland från 2010 ",
 "37: Zootopia från 2016 ",
 "38: The Hobbit: An Unexpected Journey från 2012 ",
 "39: The Dark Knight från 2008 ",
 "40: Harry Potter and the Philosopher's Stone från 2001 ",
 "41: Despicable Me 2 från 2013 ",
 "42: The Lion King från 1994 ",
 "43: The Jungle Book från 2016 ",
 "44: Pirates of the Caribbean: At World's End från 2007 ",
 "45: Jumanji: Welcome to the Jungle från 2017 ",
 "46: Harry Potter and the Deathly Hallows - Part 1 från 2010 ",
 "47: The Hobbit: The Desolation of Smaug från 2013 ",
 "48: The Hobbit: The Battle of the Five Armies från 2014 ",
 "49: Finding Nemo från 2003 ",
 "50: Harry Potter and the Order of the Phoenix från 2007 ",
};

            string menyVal = "";
            while (menyVal != "3")
            {
                Console.WriteLine("Detta program ska kunna söka efter filmer.");

                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Visa alla filmer");
                Console.WriteLine("2. Sök år");
                Console.WriteLine("3. Avsluta programmet");

                menyVal = Console.ReadLine();

                int svar = 0;
                switch (menyVal)

                {

                    case "1":

                        Console.Write("Hittade 50 filmer");
                        for (int i = 0; i < 50; i++)
                        {
                            Console.Write(filmer);
                        }


                        break;


                    case "2":
                        int antalFilmer = 0;

                        Console.WriteLine("Välj år mellan 1993-2019");
                        Console.ReadLine();

                        Console.WriteLine($"Hittade" + antalFilmer + "film.");


                        while (!int.TryParse(Console.ReadLine(), out svar) && svar <= 1992 || svar > 2020)
                        {
                            Console.WriteLine("Icke giltigt år, försök igen");
                        }

                        break;





                }
            }
        }
    }
}